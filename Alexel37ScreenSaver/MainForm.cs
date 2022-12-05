using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexel37ScreenSaver
{
    public partial class MainForm : Form
    {
        private List<ScreenConfiguration> _configurations;
        private List<SkipArea> _skips;

        private const string ConfigPath = "config.cfg";

        private bool _debugMode = true;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MultiMonitorLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.nirsoft.net/utils/multi_monitor_tool.html");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Load -= MainForm_Load;
            MultiMonitorLabel.Visible = !File.Exists("MultiMonitorTool.exe");
            _configurations = new List<ScreenConfiguration>();
            _skips = new List<SkipArea>();

            if (File.Exists(ConfigPath))
            {
                var configurations = JsonConvert.DeserializeObject<IEnumerable<ScreenConfiguration>>(File.ReadAllText(ConfigPath));
                _configurations.AddRange(configurations);
            }

            ScreensComboBox.Items.AddRange(_configurations.Select(c => c.ScreenName).ToArray());
        }

        private void AddSkipAreaButton_Click(object sender, EventArgs e)
        {
            var skip = new SkipForm();

            if (skip.ShowDialog() == DialogResult.OK)
            {
                _skips.Add(new SkipArea
                {
                    TopX = skip.TopX,
                    TopY = skip.TopY,
                    BottomX = skip.BottomX,
                    BottomY = skip.BottomY,
                });
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _configurations.Add(new ScreenConfiguration
            {
                DelaySeconds = int.Parse(DelayTextBox.Text),
                DisableMinutes = int.Parse(DisableTextBox.Text),
                ScreenName = ScreenNameTextBox.Text,
                SkipArea = new List<SkipArea>(_skips),
            });

            _skips.Clear();
        }

        private void SaveConfigurationButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(ConfigPath, JsonConvert.SerializeObject(_configurations));
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _configurations.RemoveAll(c => c.ScreenName == ScreensComboBox.Text);
            ScreensComboBox.Items.Remove(ScreensComboBox.Text);
        }

        private void ScreensComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = _configurations.First(c => c.ScreenName == ScreensComboBox.Text);
            ScreenInformationTextBox.Text = $"Disable after {selected.DisableMinutes} mintutes{Environment.NewLine}";
            ScreenInformationTextBox.Text += $"Check every {selected.DelaySeconds} seconds{Environment.NewLine}";
            ScreenInformationTextBox.Text += $"Skip areas:{Environment.NewLine}";
            ScreenInformationTextBox.Text += $"{string.Join(Environment.NewLine, selected.SkipArea.Select(a => a.ToString()))}";
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = false;
            _configurations.ForEach(c =>
            {
                var screen = Screen.AllScreens.First(s => s.DeviceName == c.ScreenName);
                _ = Task.Run(() => CheckScreen(screen.Bounds.Width, screen.Bounds.Height, screen.Bounds.X, screen.Bounds.Y, c.DisableMinutes, c.DelaySeconds, c.ScreenName, c.SkipArea));
            });
        }

        private async void CheckScreen(int width, int height, int x, int y, int disable, int delay, string name, IEnumerable<SkipArea> skip)
        {
            var timespanDelay = TimeSpan.FromSeconds(delay);
            var disableTimespan = TimeSpan.FromMinutes(disable);
            var passedTimespan = new TimeSpan();
            var size = new Size(width, height);
            bool disabled = false;

            while (true)
            {
                using (var previousBitmap = new Bitmap(width, height))
                {
                    using (var previousGraphics = Graphics.FromImage(previousBitmap))
                    {
                        previousGraphics.CopyFromScreen(x, y, 0, 0, size);
                        await Task.Delay(timespanDelay);

                        using (var currentBitmap = new Bitmap(width, height))
                        {
                            using (var currentGraphics = Graphics.FromImage(currentBitmap))
                            {
                                currentGraphics.CopyFromScreen(x, y, 0, 0, size);

                                var now = DateTime.Now;
                                var position = (0, 0);
                                if (IsCaptureChanged(previousBitmap, currentBitmap, skip, out position))
                                {
                                    passedTimespan = new TimeSpan();

                                    if(_debugMode && disabled)
                                    {
                                        previousBitmap.Save($"t1{name.Replace("\\", string.Empty)}-{position}.png");
                                        currentBitmap.Save($"t2{name.Replace("\\", string.Empty)}-{position}.png");
                                    }
                                }
                                else
                                {
                                    passedTimespan += timespanDelay + (DateTime.Now - now);
                                }
                            }
                        }
                    }
                }

                if (passedTimespan > disableTimespan)
                {
                    if (!disabled)
                    {
                        Process.Start("MultiMonitorTool.exe", $"/TurnOff {name}");
                        disabled = true;
                    }
                }
                else if (disabled)
                {
                    disabled = false;
                    Process.Start("MultiMonitorTool.exe", $"/TurnOn {name}");
                }
            }
        }

        private bool IsCaptureChanged(Bitmap previousBitmap, Bitmap currentBitmap, IEnumerable<SkipArea> skip, out (int, int) position)
        {
            for (var i = 0; i < previousBitmap.Width; i++)
            {
                for (var j = 0; j < previousBitmap.Height; j++)
                {
                    if(skip.Any(s => s.TopX < i && s.BottomX > i && s.TopY < j && s.BottomY > j))
                    {
                        continue;
                    }

                    if (previousBitmap.GetPixel(i, j) != currentBitmap.GetPixel(i, j))
                    {
                        position = (i, j);
                        return true;
                    }
                }
            }

            position = (0, 0);
            return false;
        }

        private void ToogleDebugButton_Click(object sender, EventArgs e)
        {
            _debugMode = !_debugMode;
            var text = ToogleDebugButton.Text;
            text = _debugMode ? text.Replace("Don't", string.Empty) : $"Don't {text}";
            ToogleDebugButton.Text = text;
        }
    }
}

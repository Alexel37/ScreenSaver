using System;
using System.Windows.Forms;

namespace Alexel37ScreenSaver
{
    public partial class SkipForm : Form
    {
        public SkipForm()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        public int TopX { get; set; }
        public int TopY { get; set; }
        public int BottomX { get; set; }
        public int BottomY { get; set; }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            TopX = int.Parse(TopXTextBox.Text);
            TopY = int.Parse(TopYTextBox.Text);
            BottomX = int.Parse(BottomXTextBox.Text);
            BottomY = int.Parse(BottomYTextBox.Text);
        }
    }
}

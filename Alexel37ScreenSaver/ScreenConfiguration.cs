using System.Collections.Generic;

namespace Alexel37ScreenSaver
{
    public class SkipArea
    {
        public int TopX { get; set; }
        public int TopY { get; set; }
        public int BottomX { get; set; }
        public int BottomY { get; set; }

        public override string ToString()
        {
            return $"TX:{TopX} TY:{TopY} BX:{BottomX} BY:{BottomY}";
        }
    }

    public class ScreenConfiguration
    {
        public int DisableMinutes { get; set; }

        public int DelaySeconds { get; set; }

        public string ScreenName { get; set; }

        public List<SkipArea> SkipArea { get; set; }
    }
}

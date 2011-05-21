using System;
using System.Drawing;

namespace Entities
{
    public class UserSettings
    {
        public Int32 Id { get; set; }
        public Int32 LastWindowState { get; set; }
        public Rectangle WindowBounds { get; set; }


        public UserSettings()
        {
            this.Id = -1;
            this.LastWindowState = 0;
            this.WindowBounds = new Rectangle(0, 0, 800, 600);
        }


        internal void Copy(UserSettings userSettings)
        {
            this.Id = userSettings.Id;
            this.LastWindowState = userSettings.LastWindowState;
            this.WindowBounds = userSettings.WindowBounds;
        }
    }
}

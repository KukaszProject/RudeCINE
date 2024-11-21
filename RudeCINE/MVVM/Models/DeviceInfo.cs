using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RudeCINE.MVVM.Models
{
    internal class DeviceInfo : IDeviceDisplay
    {
        public bool KeepScreenOn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DisplayInfo MainDisplayInfo => throw new NotImplementedException();
        public void ReadDeviceDisplay()
        {
            var width = DeviceDisplay.Current.MainDisplayInfo.Width;
            var height = DeviceDisplay.Current.MainDisplayInfo.Height;
        }

        public event EventHandler<DisplayInfoChangedEventArgs> MainDisplayInfoChanged;
    }
}

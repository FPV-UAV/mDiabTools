using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace mDiabTools
{
    public partial class App
    {
        public void Ble_StateChanged(object sender, Plugin.BLE.Abstractions.EventArgs.BluetoothStateChangedArgs e)
        {
            Debug.WriteLine($"The bluetooth state changed to {e.NewState}");
        }

        public static void Adapter_DeviceDiscovered(object sender, Plugin.BLE.Abstractions.EventArgs.DeviceEventArgs e)
        {
            Debug.WriteLine($"The bluetooth device discovered ID {e.Device.Id}");
            Debug.WriteLine($"The bluetooth device discovered Name {e.Device.Name}");
            Debug.WriteLine($"The bluetooth device discovered NativeDevice {e.Device.NativeDevice}");
            Debug.WriteLine($"The bluetooth device discovered RSSI {e.Device.Rssi}");
            Debug.WriteLine($"The bluetooth device discovered State {e.Device.State}");
            Debug.WriteLine($"The bluetooth device discovered AdvertisementRecords {e.Device.AdvertisementRecords}");
        }

        public static void Adapter_ScanTimeoutElapsed(object sender, EventArgs e)
        {
            Debug.WriteLine($"The bluetooth device scan timeout {e.ToString()}");
        }

        public static async void bleInit()
        {
            
            Debug.WriteLine($"The bluetooth scan start");
            await App.adapter.StartScanningForDevicesAsync();
            Debug.WriteLine($"The bluetooth scan end");
            

        }
    }
}

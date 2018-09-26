using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using mDiabTools.Services;
using mDiabTools.Views;
using Plugin.BLE;
using Plugin.BLE.Abstractions;
using Plugin.BLE.Abstractions.Contracts;
using System.Diagnostics;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace mDiabTools
{
    public partial class App : Application
    {
        public static IBluetoothLE ble;
        public static IAdapter adapter;
        public static BluetoothState bleState;
        public static int bleDeviceNo = 0;

        public static bool UseMockDataStore = true;
        
        public App()
        {
            InitializeComponent();

            ble = CrossBluetoothLE.Current;
            adapter = ble.Adapter;
            bleState = ble.State;
            adapter.ScanTimeout = 30000;
            ble.StateChanged += Ble_StateChanged;
            adapter.DeviceDiscovered += Adapter_DeviceDiscovered;
            adapter.ScanTimeoutElapsed += Adapter_ScanTimeoutElapsed;
            App.bleInit();
            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        

        protected override void OnStart()
        {                        
            
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

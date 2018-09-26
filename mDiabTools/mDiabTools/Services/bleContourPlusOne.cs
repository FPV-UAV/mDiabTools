using System;
using System.Collections.Generic;
using System.Text;


namespace mDiabTools.Services
{
    public class bleContourPlusOne
    {
        // Client Characteristic
        public static String CLIENT_CHARACTERISTIC_CONFIG = "00002902-0000-1000-8000-00805f9b34fb";
        // Glucose Service
        public static String BG_SERVICE = "00001808-0000-1000-8000-00805f9b34fb";
        // Glucose Measurement Characteristic
        public static String BG_MEASUREMENT = "00002a18-0000-1000-8000-00805f9b34fb";
        // Glucose Measurement Context Characteristic
        public static String BG_CONTEXT_MEASUREMENT = "00002A34-0000-1000-8000-00805f9b34fb";
        // Glucose Feature Characteristic
        public static String BG_FEATURE = "00002A51-0000-1000-8000-00805f9b34fb";
        // Record Access Control Point characteristic
        public static String BG_ACCESS_CONTROL_POINT = "00002A52-0000-1000-8000-00805f9b34fb";


        public static int STATE_DISCONNECTED = 0;
        public static int STATE_CONNECTING = 1;
        public static int STATE_CONNECTED = 2;
        public static int mConnectionState = STATE_DISCONNECTED;
        public static Guid GUID_BG_MEASUREMENT = Guid.Parse(BG_MEASUREMENT);
    }


}

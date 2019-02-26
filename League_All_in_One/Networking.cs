using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace League_All_in_One
{
    static class Networking
    {
        private static string NAIP = "104.160.131.3";
        private static string EUWIP = "104.160.141.3";
        private static string EUNEIP = "104.160.142.3";
        private static string OCEIP = "104.160.156.1";
        private static string LANIP = "104.160.136.3";
        
        private static Ping myPing = new Ping();
        

        public static string PingNaServer()
        {
            string result = "";
            try
            {
                PingReply pingReply = myPing.Send(NAIP, 1000);
                if (pingReply != null)
                {
                    result = pingReply.RoundtripTime.ToString();
                }
            }
            catch
            {
                result = "Error: TIMEOUT.";
            }
            return result;
        }

        public static string PingEUWServer()
        {
            string result = "";
            try
            {
                PingReply pingReply = myPing.Send(EUWIP, 1000);
                if (pingReply != null)
                {
                    result = pingReply.RoundtripTime.ToString();
                }
            }
            catch
            {
                result = "Error: TIMEOUT.";
            }
            return result;
        }

        public static string PingEUNEServer()
        {
            string result = "";
            try
            {
                PingReply pingReply = myPing.Send(EUNEIP, 1000);
                if (pingReply != null)
                {
                    result = pingReply.RoundtripTime.ToString();
                }
            }
            catch
            {
                result = "Error: TIMEOUT.";
            }
            return result;
        }

        public static string PingOCEServer()
        {
            string result = "";
            try
            {
                PingReply pingReply = myPing.Send(OCEIP, 1000);
                if (pingReply != null)
                {
                    result = pingReply.RoundtripTime.ToString();
                }
            }
            catch
            {
                result = "Error: TIMEOUT.";
            }
            return result;
        }

        public static string PingLANServer()
        {
            string result = "";
            try
            {
                PingReply pingReply = myPing.Send(LANIP, 1000);
                if (pingReply != null)
                {
                    result = pingReply.RoundtripTime.ToString();
                }
            }
            catch
            {
                result = "Error: TIMEOUT.";
            }
            return result;
        }
    }
}

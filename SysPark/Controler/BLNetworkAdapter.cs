using System;
using System.Linq;
using System.Net.NetworkInformation;

namespace SysPark.Controler
{
    public static class BLNetworkAdapter
    {
        private static readonly string mac;
        private static readonly string ip;

        public static string Mac
        {
            get { return mac; }
        }

        public static string Ip
        {
            get { return ip; }
        }

        static BLNetworkAdapter()
        {
            try
            {
                //var objMos = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = 'TRUE'");
                //var objMoc = objMos.Get();

                //foreach (var addresses in from ManagementObject mo in objMoc
                //                          select (string[])mo["IPAddress"])
                //{
                //    ip = addresses[0];

                //    mac = addresses[1];
                //}
                mac =
                (
                    from nic in NetworkInterface.GetAllNetworkInterfaces()
                    where nic.OperationalStatus == OperationalStatus.Up
                    select nic.GetPhysicalAddress().ToString()
                ).FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
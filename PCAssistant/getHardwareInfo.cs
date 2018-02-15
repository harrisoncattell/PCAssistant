using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Threading.Tasks;

namespace PCAssistant
{
    public class getHardwareInfo
    {

       
        //Get Serial Number
        public static string getSerialNumber()
        {

            string Serial_No = string.Empty;

            ManagementObjectSearcher System_Searcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BaseBoard");

            foreach (ManagementObject obj in System_Searcher.Get())
            {

                Serial_No = obj["SerialNumber"].ToString();

            }

            return Serial_No;

        }

        //Get OS Information
        public static string getOS()
        {

            string OS = Environment.OSVersion.ToString();

            return OS;

        }

        //Get System Architecture
        public static string getArchitecture()
        {

            if(Environment.Is64BitOperatingSystem == true)
            {

                return "1";

            }

            else
            {

                return "0";

            }

        }

        //Get System Architecture
        public static string getProcessorName()
        {

            string CPU_Name = string.Empty;

            ManagementObjectSearcher System_Searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");

            foreach (ManagementObject obj in System_Searcher.Get())
            {

                CPU_Name = obj["Name"].ToString();

            }

            return CPU_Name;

        }

        //Get Disk Info
        public static string getDiskInfo()
        {

            UInt64 Disk_Size = 0;
            UInt64 Conversion_Number = 800000000;
            string Volume_Name = string.Empty;

            ManagementObjectSearcher System_Searcher_1 = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            foreach (ManagementObject obj in System_Searcher_1.Get())
            {

                Volume_Name = obj["Name"].ToString();

            }

            ManagementObjectSearcher System_Searcher_2 = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk");

            foreach (ManagementObject obj in System_Searcher_2.Get())
            {

                Disk_Size = (Convert.ToUInt64(obj["Size"]) / Conversion_Number);

            }

            string Disk_Info = Volume_Name + ", " + Disk_Size + " GB";

            return Disk_Info;

        }

        public static string getDiskStatus()
        {

            string Status = string.Empty;

            ManagementObjectSearcher System_Searcher = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk");

            foreach (ManagementObject obj in System_Searcher.Get())
            {

                Status = Convert.ToString(Convert.ToInt32(obj["ConfigManagerErrorCode"]));

            }

            return Status;

        }

    }
}

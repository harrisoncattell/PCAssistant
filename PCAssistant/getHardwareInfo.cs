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
        public static string getProcessorID()
        {

            ManagementClass man1 = new ManagementClass("win32_processor");
            ManagementObjectCollection moc1 = man1.GetInstances();

            string ID = String.Empty;

            foreach (ManagementObject moc in moc1)
            {

                ID = moc.Properties["processorID"].Value.ToString();

            }

            return ID;

        }

        public static string getOS()
        {

            string OS = Environment.OSVersion.ToString();

            return OS;

        }

        public static string is64bitSystem()
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

        public static string getCPUManufacturer()
        {

            if (Environment.Is64BitOperatingSystem == true)
            {

                return "1";

            }

            else
            {

                return "0";

            }

        }

    }
}

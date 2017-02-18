using System.Collections.Generic;

namespace SysLogForwarder
{
    class syslogFacilities
    {
        public syslogFacilities()
        {
            initClass();
        }

        private void initClass()
        {
            // TODO: finish list
            facmap = new Dictionary<int, string>();
            facmap.Add(0, "kern");
            facmap.Add(1,"user");
            facmap.Add(2,"mail");
            facmap.Add(3,"daemon");
            facmap.Add(4,"auth");
            facmap.Add(5,"syslog");
            facmap.Add(6,"lpr");
            facmap.Add(7,"news");
            facmap.Add(8,"uucp");
            facmap.Add(9, "clock");
            facmap.Add(10, "authpriv");
            facmap.Add(11, "ftp");
            facmap.Add(12, "ntp");
            facmap.Add(13, "audit");
            facmap.Add(14, "alert");
            facmap.Add(15, "cron");
            facmap.Add(16, "local0");
            facmap.Add(17, "local1");
            facmap.Add(18, "local2");
            facmap.Add(19, "local3");
            facmap.Add(20, "local4");
            facmap.Add(21, "local5");
            facmap.Add(22, "local6");
            facmap.Add(23, "local7");
        }

        public string getFacilityName(int num)
        {
            // TODO: check bounds
            if (facmap.ContainsKey(num))
            {
                return facmap[num];
            } else {
                return "unknown facility";
            }
        }

        public int getFacilityNumber(string name)
        {
            foreach(KeyValuePair<int, string>item in facmap)
            {
                if (name == item.Value) return item.Key;
            }

            return -1;
        }

        private Dictionary<int, string> facmap;
    }
}
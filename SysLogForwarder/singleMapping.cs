using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SysLogForwarder
{
    public class singleMapping
    {
        public singleMapping()
        {
            hasfilter = false;
            negFilter = false;
        }

        public void setLocalLog(String localLogName)
        {
            localLog = localLogName;
        }

        public void setPrefix(String tp)
        {
            prefix = tp;
        }

        public void setFacility(int fac)
        {
            syslogFacilities sl = new syslogFacilities();
            if (sl.isValid(fac))
            {
                sysFac = fac;
            } else
            {
                sysFac = 0;
            }
        }

        public void setFilter(String filter)
        {
            // we shoudl check the filter is ok first.. for now, no
            Trace.Write("got " + filter + "\r\n");
            if (filter.Length > 1)
            {
                if (filter[0] == '!') negFilter = true;
                else negFilter = false;
                regexfilter = filter.TrimStart('!');
                hasfilter = true;
            }
            else hasfilter = false;

            Trace.Write("set hasfilter " + hasfilter.ToString() + " and " + negFilter.ToString() + "\r\n");
        }

        public bool tryFilter(String logval)
        {
            if (!hasfilter) return true;

            Regex myr = new Regex(regexfilter, RegexOptions.IgnoreCase);
            Match mym = myr.Match(logval);

            // theres a better way to do this
            if(negFilter)
            {
                return !mym.Success;
            } else
            {
                return mym.Success;
            }
        }

        public void setTrim(bool trim)
        {
            doTrim = trim;
        }

        public String getLocalLog()
        {
            return localLog;
        }

        public int getFacility()
        {
            return sysFac;
        }

        public String toString()
        {
            String myval;
            myval = "mapping;" + sysFac.ToString() + ";" + doTrim.ToString() + ";" + localLog + ";";
            if (negFilter) myval += "!";
            myval += regexfilter + ";" + prefix;
            Trace.Write("sent: " + myval + "\r\n");

            return myval;
        }


        public bool fromString(String val)
        {
            Trace.Write("got:" + val + "\r\n");
            String[] sep = { ";" }; // what a stupid way to split strings
            String[] av = val.Split(sep, StringSplitOptions.None);
            if (av.Length != 6) return false;
            if (av[0] != "mapping") return false;

            sysFac = Int32.Parse(av[1]);
            doTrim = Convert.ToBoolean(av[2]);
            localLog = av[3];
            setFilter(av[4]);
            setPrefix(av[5]);

            return true;
        }

        private String regexfilter;
        private bool hasfilter;
        private bool negFilter;
        private int sysFac;
        private bool doTrim;
        private String localLog;
        private String prefix;


    }
}

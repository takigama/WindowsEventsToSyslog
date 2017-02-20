using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLogForwarder
{
    public class syslogHost
    {
        public syslogHost()
        {
            hosts = new Dictionary<int, singleSyslogHost>();
        }

        public int addHost(singleSyslogHost sm)
        {
            Trace.WriteLine("begin add");
            int i = 0;

            // find the next key
            Trace.WriteLine("find key");
            while (hosts.ContainsKey(i)) i++;

            Trace.WriteLine("add host");
            hosts.Add(i, sm);

            return i;
        }

        public bool removeHost(int map)
        {
            if (!hosts.ContainsKey(map)) return false;

            hosts.Remove(map);

            int sval = map + 1;
            while (hosts.ContainsKey(sval))
            {
                singleSyslogHost sm = hosts[sval];
                hosts.Remove(sval);
                hosts[sval - 1] = sm;
                sval++;
            }
            return true;
        }

        public singleSyslogHost getMap(int n)
        {
            return hosts[n];
        }

        public void dumpMap()
        {
            int i = 0;


            // find the next key
            while (hosts.ContainsKey(i))
            {
                Trace.Write("have map at " + i.ToString() + "\r\n");
                i++;

            }

            Trace.Write("finidhed\r\n\r\n\r\n");
        }

        // dumps out all hosts as their string variants
        public String toString()
        {
            String retval = "";
            foreach(KeyValuePair<int, singleSyslogHost>host in hosts)
            {
                retval += host.Value.toString() + "\r";
            }

            Trace.WriteLine("retval is " + retval);
            return retval;
        }

        public bool fromString(String load)
        {
            String[] sep = { "\r" };
            String[] av = load.Split(sep, StringSplitOptions.None);
            
            for(int i=0; i < av.Length; i++)
            {
                singleSyslogHost ism = new singleSyslogHost();
                Trace.WriteLine("line is " +av[i]);
                if(ism.fromString(av[i]))
                {
                    Trace.WriteLine("added");
                    addHost(ism);
                } else
                {
                    Trace.WriteLine("not added");
                }
            }

            return true;

        }

        public int getNMaps()
        {
            return hosts.Count();
        }

        private Dictionary<int, singleSyslogHost> hosts;

    }
}

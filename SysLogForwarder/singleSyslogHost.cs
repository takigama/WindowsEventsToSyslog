using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLogForwarder
{
    public class singleSyslogHost
    {
        public singleSyslogHost()
        {
            port = 514;
            protocol = 1;
        }

        public void setHostAddress(String addr)
        {
            // port is set by doing hostname:234
            // which we'll implement one day!
            hostAddress = addr;
        }

        public void setProtocol(int prot)
        {
            protocol = prot;
        }

        public void setRole(int sr)
        {
            role = sr;
        }

        public String toString()
        {
            String value = "sysloghost";
            value += ";" + protocol.ToString() + ";" + port.ToString() + ";" + role.ToString() + ";" + hostAddress;
            Trace.Write("sent:" + value + "\r\n");
            return value;
        }

        public bool fromString(String val)
        {
            Trace.Write("got:" + val + "\r\n");
            String[] sep = { ";" }; // what a stupid way to split strings
            String[] av = val.Split(sep, StringSplitOptions.None);
            if (av.Length!= 5) return false;
            if (av[0] != "sysloghost") return false;

            protocol = Int32.Parse(av[1]);
            port = Int32.Parse(av[2]);
            role = Int32.Parse(av[3]);
            hostAddress = av[4];

            return true;
        }

        private String hostAddress;
        private int protocol; // 1 = tcp, 2 = udp
        private int port;
        private int role; // 1 = primary, 2 = secondary;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLogForwarder
{
    class singleMapping
    {
        singleMapping()
        {

        }

        public bool setMapping()
        {
            return false;
        }

        public void setLocalLog()
        {

        }

        public void setFacility(int fac)
        {

        }

        public void setFilter(String fitler)
        {

        }

        public String getLocalLog()
        {
            return "";
        }

        public int getFacility()
        {
            return 0;
        }

        private String regexfilter;
        private bool negFilter;
        private syslogFacilities sysFac; 


    }
}

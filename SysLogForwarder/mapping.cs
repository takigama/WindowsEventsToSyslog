using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLogForwarder
{
    public class mapping
    {
        public mapping()
        {
            mappings = new Dictionary<int, singleMapping>();
        }

        private bool loadMappings()
        {

            return false;   
        }

        public String[] getMappingView()
        {
            return null;
        }

        public int addMapping(singleMapping sm)
        {
            int i = 0;
            
            // find the next key
            while (mappings.ContainsKey(i)) i++;

            mappings.Add(i, sm);

            return i;
        }

        public bool removeMapping(int map)
        {
            if (!mappings.ContainsKey(map)) return false;

            mappings.Remove(map);

            int sval = map+1;
            while(mappings.ContainsKey(sval))
            {
                singleMapping sm = mappings[sval];
                mappings.Remove(sval);
                mappings[sval - 1] = sm;
                sval++;
            }
            return true;
        }

        public singleMapping getMap(int n)
        {
            return mappings[n];
        }
        
        public void dumpMap()
        {
            int i = 0;


            // find the next key
            while (mappings.ContainsKey(i))
            {
                Trace.Write("have map at " + i.ToString() + "\r\n");
                i++;

            }

            Trace.Write("finidhed\r\n\r\n\r\n");
        }

        public int getNMaps()
        {
            return mappings.Count();
        }


        private Dictionary <int,singleMapping>mappings;

    }
}

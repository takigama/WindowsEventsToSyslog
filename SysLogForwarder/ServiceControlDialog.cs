using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysLogForwarder
{
    public partial class ServiceControlDialog : Form
    {
        public ServiceControlDialog()
        {
            InitializeComponent();

            // setup some default data
            mData = new mapping();
            selectedMapping = -1;
            mappingListView.SelectedIndex = -1;

            // init the base drop boxes
            initFacilities();
            initLocalLog();
            initProtocol();
            initRoles();
            mappingTrim.Checked = true;
        }

        private void initRoles()
        {
            syslogRoleCB.Items.Add("Primary");
            syslogRoleCB.Items.Add("Secondary");
            syslogRoleCB.Items.Add("Disabled");
            syslogRoleCB.SelectedIndex = 0;
        }

        private void initProtocol()
        {
            syslogProtocolCB.Items.Add("TCP (Prefered)");
            syslogProtocolCB.Items.Add("UDP");
            syslogProtocolCB.SelectedIndex = 0;

        }

        private void initLocalLog()
        {
            EventLog[] ev = EventLog.GetEventLogs();
            foreach(EventLog e in ev)
            {
                localLog.Items.Add(e.LogDisplayName);
            }
            localLog.SelectedIndex = 0;
        }

        private void initFacilities()
        {
            syslogFacilities sl = new syslogFacilities();

            int i = 0;

            while(sl.getFacilityName(i) != null)
            {
                syslogFacility.Items.Add(i.ToString() + ": " + sl.getFacilityName(i));
                i++;
            }
            syslogFacility.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void serviceStatus_Enter(object sender, EventArgs e)
        {

        }

        private void serviceStatusImage_Click(object sender, EventArgs e)
        {

        }

        private void mappingListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mappingGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void mappingBox_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void syslogFacility_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mappingAddButton_Click(object sender, EventArgs e)
        {
            String reg = mappingFilter.Text;
            String pref = mappingPrefix.Text;
            String local = localLog.Text;
            String fac = syslogFacility.Text;
            int selind = syslogFacility.SelectedIndex;
            bool trim = mappingTrim.Checked;

            if (selectedMapping == -1)
            {

                // this next link is a bit of a copout and i should do it better
                Console.WriteLine("stuff is " + reg + " and " + pref + " and " + trim.ToString() + " and " + local + " and " + fac + " which is " + selind);

                singleMapping sm = new singleMapping();

                sm.setFilter(reg);
                sm.setPrefix(pref);
                sm.setTrim(trim);
                sm.setFacility(selind);
                sm.setLocalLog(local);
                mData.addMapping(sm);
            } else
            {
                // we're modifying an existing mapping... what could possiblie go wrong?
                mData.getMap(selectedMapping).setFacility(selind);
                mData.getMap(selectedMapping).setFilter(reg);
                mData.getMap(selectedMapping).setPrefix(pref);
                mData.getMap(selectedMapping).setLocalLog(local);
                mData.getMap(selectedMapping).setTrim(trim);


            }
            redrawMappingList();
        }


        private void mappingListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nselectm = mappingListView.SelectedIndex;

            //if (nselectm == -1) return;

            if (nselectm == selectedMapping || nselectm == -1)
            {
                // if we select someting twice, we deselect all.

                // nothing selected, revert forms to default value... perhaps we shouldnt do this?
                // you could select an item like what you want, deselect it and use it to add a new one
                mappingListView.SelectedIndex = -1;
                selectedMapping = -1;
                mappingRemoveButton.Enabled = false;
                //mappingFilter.Text = "";
                //mappingPrefix.Text = "";
                //localLog.SelectedIndex = 0;
                //syslogFacility.SelectedIndex = 0;
                mappingAddButton.Text = "Add";
                //mappingTrim.Checked = false;


            }
            else
            {
                // somthing is selected, load its data into the form so we can edit it
                selectedMapping = nselectm;
                mappingRemoveButton.Enabled = true;
                singleMapping sm = mData.getMap(nselectm);

                // supprised this works, but kewl!
                localLog.SelectedIndex = localLog.FindString(mData.getMap(nselectm).getLocalLog());
                syslogFacility.SelectedIndex = sm.getFacility();
                mappingFilter.Text = sm.getFilter();
                mappingPrefix.Text = sm.getPrefix();
                mappingTrim.Checked = sm.getTrim();

                // change Add to Save
                mappingAddButton.Text = "Modify";
            }
            Console.WriteLine("select changed to " + selectedMapping.ToString());
        }



        private void redrawMappingList()
        {
            for (int n = mappingListView.Items.Count - 1; n >= 0; --n)
            {
                mappingListView.Items.RemoveAt(n);
            }

            for(int k = 0; k<mData.getNMaps(); k++)
            {
                mappingListView.Items.Add(mData.getMap(k).getTxtRepresentation());
            }

            
        }

        private void mappingRemoveButton_Click(object sender, EventArgs e)
        {
            // here we remove selected mapping
            // this too is a bit of a dodge, im sure i could get out of
            // sync between what is selected ad the data in mdata.
            mData.removeMapping(selectedMapping);
            redrawMappingList();
        }





        private int selectedMapping;
        private mapping mData;

    }
}

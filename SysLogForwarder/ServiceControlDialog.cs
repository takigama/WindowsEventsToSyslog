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

            initFacilities();
            initLocalLog();
            initProtocol();
            initRoles();
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

        private void mappingListView_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Uptime_Counter3
{
    public partial class Form2 : Form
    {
        public DatabaseWrapper dbWrap;
        private tableStorage tS;
        RegistryKey rkApp;

        public Form2()
        {
            InitializeComponent();
            listViewInit();
            dbWrap = new DatabaseWrapper("baza.sqlite");
            tS = new tableStorage();
            dbWrap.saveTimer();
            lRun.Text = (dbWrap.countRunx()).ToString();
            rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (rkApp.GetValue("Uptime_Counter3") == null)
            {
                startupCheckbox.Checked = false;
            }
            else
            {
                startupCheckbox.Checked = true;
            }
        }

        public void listViewInit()
        {
            listView1.View = View.Details;
            listView1.Columns.Clear();
            ColumnHeader header1, header2,header3,header4,header5;
            header1 = new ColumnHeader();
            header2 = new ColumnHeader();
            header3 = new ColumnHeader();
            header4 = new ColumnHeader();
            header5 = new ColumnHeader();
            header1.Text = "Data rozpoczęcia";
            header2.Text = "Data zakończenia";
            header3.Text = "Różnica";
            header4.Text = "Offline";
            header5.Text = "Rzeczywisty";
            header1.TextAlign = header2.TextAlign = header3.TextAlign = header4.TextAlign = header5.TextAlign = HorizontalAlignment.Center;
            header1.Width = header2.Width = header3.Width = header4.Width = header5.Width = -1;
            listView1.Columns.Add(header1);
            listView1.Columns.Add(header2);
            listView1.Columns.Add(header3);
            listView1.Columns.Add(header4);
            listView1.Columns.Add(header5);
            listView1.Items.Add("0000-00-00 00:00:00");
            listView1.Items[0].SubItems.Add("0000-00-00 00:00:00");
            listView1.Items[0].SubItems.Add("0 d  00 : 00 : 00");
            listView1.Items[0].SubItems.Add("0 d  00 : 00 : 00");
            listView1.Items[0].SubItems.Add("0 d  00 : 00 : 00");
        }

        public void populateListView(tableStorage tS)
        {
            int i = 0;
            
            foreach (string s in tS.getBeginDateTime())
            {
                listView1.Items.Add(s);
            }

            foreach (string s in tS.getEndDateTime())
            {
                listView1.Items[i].SubItems.Add(s);
                i++;
            }
            i = 0;

            foreach (string s in tS.getElapsedTime())
            {
                listView1.Items[i].SubItems.Add(s);
                i++;
            }

            i=0;
            foreach (string s in tS.getofflineTime())
            {
                listView1.Items[i].SubItems.Add(s);
                i++;
            }

            i = 0;
            foreach (string s in tS.getRealTime())
            {
                listView1.Items[i].SubItems.Add(s);
                i++;
            }
        }

        int countElem() { return listView1.Items.Count; }

        private void tableStorageUpButton_Click(object sender, EventArgs e)
        {
            dbWrap.saveTimer();
            UInt32 curr = Form1.tmptime + Form1.counter.convertTo();
            UInt32 hib = dbWrap.getTotalOfflineTime();
            label7.Text = Counter.convertFrom(dbWrap.getTotalOfflineTime());
            lRealTime.Text = Counter.convertFrom(curr-hib);
            lLongestTime.Text = Counter.convertFrom(dbWrap.getLongest());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lTotalTime_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lRun_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lLongestTime_Click(object sender, EventArgs e)
        {

        }

        private void Form2_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lRealTime_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            dbWrap.saveTimer();
            listView1.Items.Clear();
            dbWrap.populateTableStorage(tS);
            populateListView(tS);
            tS.Clear();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void startupCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (rkApp.GetValue("Uptime_Counter3") == null)
            {
                rkApp.SetValue("Uptime_Counter3", Application.ExecutablePath.ToString());
            }
            else
            {
                rkApp.DeleteValue("Uptime_Counter3", false);
            }
        }

    }
}

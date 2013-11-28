using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Uptime_Counter3
{
    public partial class Form1 : Form
    {
        private Form2 F2;
        public static Counter counter;
        private Thread counterThread;
        private Thread helperThread;
        public string dateTime;
        public static UInt32 tmptime;
        int working=0;

        public Form1()
        {
            InitializeComponent();
            F2 = new Form2();
            dateTime = F2.dbWrap.getCurrentDateTime();
            components = new System.ComponentModel.Container();
            counter = new Counter();
            counter.setOfflineCheckString(F2.dbWrap.getCurrentDateTime());
            load();
            tmptime = F2.dbWrap.getTotalTime(0);
            notifyIcon1.ShowBalloonTip(200, "", "Uptime_Counter został uruchomiony.", ToolTipIcon.None);
        }

        private void load()
        {
            this.Hide();
            counterThread = new Thread(() => updateGUI(counter));
            helperThread = new Thread(() => helperGUI());
            counterThread.Start();
            helperThread.Start();
        }

        public delegate void serviceGUIDelegate(Counter counter);
        private void updateGUI(Counter counter)
        {
            while (true)
            {
                try
                {
                    Thread.Sleep(1000);
                    Invoke(new EventHandler(delegate { up(counter); }));
                }
                catch (InvalidOperationException) { }
            }
        }

        private void helperGUI()
        {
            while (true)
            {
                try
                {
                    Thread.Sleep(1000);
                    Invoke(new EventHandler(delegate { helperProc(); }));
                }
                catch (InvalidOperationException) { }
            }
        }


        private void up(Counter counter)
        {
            counter.countUP();
        }

        private void helperProc()
        {
            currentTimeLabel.Text = counter.getTimeString();
            F2.lTotalTime.Text = Counter.convertFrom(tmptime + counter.convertTo());
            if (counter.checkSaveNeed())
            {
                F2.dbWrap.saveTimer(); working = working + 1;
                notifyIcon1.ShowBalloonTip(200, "", "Minęła godzina. Program działa już od " + working + "h!", ToolTipIcon.None);
                counter.flipSaveNeed();
            }

            if (counter.checkOfflineCheckNeed())
            {
                if (counter.checkOfflineState(F2.dbWrap))
                {
                    F2.dbWrap.execSimpleCmd("update historia set hiber="+counter.offlineTotalTime+" where rozp='"+F2.dbWrap.getInitDateTime()+"'");
                    counter.flipOfflineCheckNeed();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            F2.dbWrap.saveTimer();
            counterThread.Abort();
            helperThread.Abort();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            F2.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void currentTimeLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

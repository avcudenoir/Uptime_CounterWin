namespace Uptime_Counter3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bClear = new System.Windows.Forms.Button();
            this.bLoad = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lRealTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lRun = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lLongestTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lTotalTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableStorageUpButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.startupCheckbox = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(523, 315);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bClear);
            this.tabPage1.Controls.Add(this.bLoad);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lRealTime);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.lRun);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lLongestTime);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lTotalTime);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tableStorageUpButton);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(515, 286);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Baza";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(449, 171);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(60, 21);
            this.bClear.TabIndex = 15;
            this.bClear.Text = "Wyczyść";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(385, 171);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(58, 21);
            this.bLoad.TabIndex = 14;
            this.bLoad.Text = "Załaduj";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "v 3.3 by Alan Matuszczak | 06.05.2013";
            // 
            // lRealTime
            // 
            this.lRealTime.AutoSize = true;
            this.lRealTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lRealTime.Location = new System.Drawing.Point(169, 217);
            this.lRealTime.Name = "lRealTime";
            this.lRealTime.Size = new System.Drawing.Size(57, 14);
            this.lRealTime.TabIndex = 12;
            this.lRealTime.Text = "Odśwież";
            this.lRealTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lRealTime.Click += new System.EventHandler(this.lRealTime_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(8, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 14);
            this.label8.TabIndex = 11;
            this.label8.Text = "Rzeczywisty łączny czas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(169, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 14);
            this.label7.TabIndex = 10;
            this.label7.Text = "Odśwież";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(9, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "Wstrzymanie/Hibernacja:";
            // 
            // lRun
            // 
            this.lRun.AutoSize = true;
            this.lRun.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lRun.Location = new System.Drawing.Point(169, 261);
            this.lRun.Name = "lRun";
            this.lRun.Size = new System.Drawing.Size(15, 14);
            this.lRun.TabIndex = 8;
            this.lRun.Text = "0";
            this.lRun.Click += new System.EventHandler(this.lRun_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(9, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Uruchomień: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lLongestTime
            // 
            this.lLongestTime.AutoSize = true;
            this.lLongestTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lLongestTime.Location = new System.Drawing.Point(169, 239);
            this.lLongestTime.Name = "lLongestTime";
            this.lLongestTime.Size = new System.Drawing.Size(57, 14);
            this.lLongestTime.TabIndex = 6;
            this.lLongestTime.Text = "Odśwież";
            this.lLongestTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lLongestTime.Click += new System.EventHandler(this.lLongestTime_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(8, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Najdłuższy pomiar: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lTotalTime
            // 
            this.lTotalTime.AutoSize = true;
            this.lTotalTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lTotalTime.Location = new System.Drawing.Point(169, 171);
            this.lTotalTime.Name = "lTotalTime";
            this.lTotalTime.Size = new System.Drawing.Size(87, 14);
            this.lTotalTime.TabIndex = 3;
            this.lTotalTime.Text = "0d  00:00:00";
            this.lTotalTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lTotalTime.Click += new System.EventHandler(this.lTotalTime_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Łączny czas: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableStorageUpButton
            // 
            this.tableStorageUpButton.Location = new System.Drawing.Point(407, 213);
            this.tableStorageUpButton.Name = "tableStorageUpButton";
            this.tableStorageUpButton.Size = new System.Drawing.Size(75, 23);
            this.tableStorageUpButton.TabIndex = 1;
            this.tableStorageUpButton.Text = "Odśwież";
            this.tableStorageUpButton.UseVisualStyleBackColor = true;
            this.tableStorageUpButton.Click += new System.EventHandler(this.tableStorageUpButton_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(3, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(508, 165);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.startupCheckbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(515, 286);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Autostart";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // startupCheckbox
            // 
            this.startupCheckbox.AutoSize = true;
            this.startupCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startupCheckbox.Location = new System.Drawing.Point(79, 129);
            this.startupCheckbox.Name = "startupCheckbox";
            this.startupCheckbox.Size = new System.Drawing.Size(386, 20);
            this.startupCheckbox.TabIndex = 0;
            this.startupCheckbox.Text = "Uruchom Uptime_Counter przy włączeniu komputera";
            this.startupCheckbox.UseVisualStyleBackColor = true;
            this.startupCheckbox.CheckedChanged += new System.EventHandler(this.startupCheckbox_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 315);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statystyki";
            this.VisibleChanged += new System.EventHandler(this.Form2_VisibleChanged);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button tableStorageUpButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lLongestTime;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lTotalTime;
        private System.Windows.Forms.Label lRun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lRealTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox startupCheckbox;
    }
}
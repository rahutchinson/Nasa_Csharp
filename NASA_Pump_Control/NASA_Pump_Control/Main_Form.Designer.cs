namespace NASA_Pump_Control
{
    partial class Pump_Form
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
            this.Pump1_GrpBox = new System.Windows.Forms.GroupBox();
            this.grp_next = new System.Windows.Forms.GroupBox();
            this.btn_total_time = new System.Windows.Forms.Button();
            this.btn_offtime = new System.Windows.Forms.Button();
            this.btn_runtime = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_run = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pumpActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_baud = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_comport = new System.Windows.Forms.TextBox();
            this.btn_halt = new System.Windows.Forms.Button();
            this.btn_test = new System.Windows.Forms.Button();
            this.chk_setspeed = new System.Windows.Forms.CheckBox();
            this.lbl_speed = new System.Windows.Forms.Label();
            this.txt_speed = new System.Windows.Forms.TextBox();
            this.chk_config = new System.Windows.Forms.CheckBox();
            this.Pump1_GrpBox.SuspendLayout();
            this.grp_next.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pump1_GrpBox
            // 
            this.Pump1_GrpBox.Controls.Add(this.grp_next);
            this.Pump1_GrpBox.Controls.Add(this.groupBox2);
            this.Pump1_GrpBox.Controls.Add(this.btn_run);
            this.Pump1_GrpBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pump1_GrpBox.Location = new System.Drawing.Point(12, 27);
            this.Pump1_GrpBox.Name = "Pump1_GrpBox";
            this.Pump1_GrpBox.Size = new System.Drawing.Size(275, 370);
            this.Pump1_GrpBox.TabIndex = 0;
            this.Pump1_GrpBox.TabStop = false;
            this.Pump1_GrpBox.Text = "Pump 1";
            // 
            // grp_next
            // 
            this.grp_next.Controls.Add(this.btn_total_time);
            this.grp_next.Controls.Add(this.btn_offtime);
            this.grp_next.Controls.Add(this.btn_runtime);
            this.grp_next.Location = new System.Drawing.Point(13, 92);
            this.grp_next.Name = "grp_next";
            this.grp_next.Size = new System.Drawing.Size(200, 85);
            this.grp_next.TabIndex = 7;
            this.grp_next.TabStop = false;
            this.grp_next.Text = "What\'s next?";
            // 
            // btn_total_time
            // 
            this.btn_total_time.Location = new System.Drawing.Point(6, 19);
            this.btn_total_time.Name = "btn_total_time";
            this.btn_total_time.Size = new System.Drawing.Size(75, 39);
            this.btn_total_time.TabIndex = 4;
            this.btn_total_time.Text = "Add Total runtime";
            this.btn_total_time.UseVisualStyleBackColor = true;
            // 
            // btn_offtime
            // 
            this.btn_offtime.Location = new System.Drawing.Point(87, 48);
            this.btn_offtime.Name = "btn_offtime";
            this.btn_offtime.Size = new System.Drawing.Size(75, 23);
            this.btn_offtime.TabIndex = 6;
            this.btn_offtime.Text = "add offtime";
            this.btn_offtime.UseVisualStyleBackColor = true;
            // 
            // btn_runtime
            // 
            this.btn_runtime.Location = new System.Drawing.Point(87, 19);
            this.btn_runtime.Name = "btn_runtime";
            this.btn_runtime.Size = new System.Drawing.Size(75, 23);
            this.btn_runtime.TabIndex = 5;
            this.btn_runtime.Text = "add runtime";
            this.btn_runtime.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(13, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 67);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flow Rate";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 19);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(116, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(194, 341);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 23);
            this.btn_run.TabIndex = 0;
            this.btn_run.Text = "Run!";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pumpActionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1070, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pumpActionsToolStripMenuItem
            // 
            this.pumpActionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPumpToolStripMenuItem});
            this.pumpActionsToolStripMenuItem.Name = "pumpActionsToolStripMenuItem";
            this.pumpActionsToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.pumpActionsToolStripMenuItem.Text = "Pump Actions";
            // 
            // newPumpToolStripMenuItem
            // 
            this.newPumpToolStripMenuItem.Name = "newPumpToolStripMenuItem";
            this.newPumpToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.newPumpToolStripMenuItem.Text = "New Pump";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_baud);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_comport);
            this.groupBox1.Controls.Add(this.btn_halt);
            this.groupBox1.Controls.Add(this.btn_test);
            this.groupBox1.Controls.Add(this.chk_setspeed);
            this.groupBox1.Controls.Add(this.lbl_speed);
            this.groupBox1.Controls.Add(this.txt_speed);
            this.groupBox1.Controls.Add(this.chk_config);
            this.groupBox1.Location = new System.Drawing.Point(865, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 379);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Testing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Baud Rate";
            // 
            // cmb_baud
            // 
            this.cmb_baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_baud.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_baud.FormattingEnabled = true;
            this.cmb_baud.Items.AddRange(new object[] {
            "4800",
            "9600"});
            this.cmb_baud.Location = new System.Drawing.Point(6, 82);
            this.cmb_baud.Name = "cmb_baud";
            this.cmb_baud.Size = new System.Drawing.Size(121, 21);
            this.cmb_baud.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Com Port";
            // 
            // txt_comport
            // 
            this.txt_comport.Location = new System.Drawing.Point(7, 44);
            this.txt_comport.Name = "txt_comport";
            this.txt_comport.Size = new System.Drawing.Size(100, 20);
            this.txt_comport.TabIndex = 6;
            // 
            // btn_halt
            // 
            this.btn_halt.Location = new System.Drawing.Point(88, 263);
            this.btn_halt.Name = "btn_halt";
            this.btn_halt.Size = new System.Drawing.Size(75, 23);
            this.btn_halt.TabIndex = 5;
            this.btn_halt.Text = "Halt";
            this.btn_halt.UseVisualStyleBackColor = true;
            this.btn_halt.Click += new System.EventHandler(this.btn_halt_Click);
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(7, 263);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(75, 23);
            this.btn_test.TabIndex = 4;
            this.btn_test.Text = "Test";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // chk_setspeed
            // 
            this.chk_setspeed.AutoSize = true;
            this.chk_setspeed.Location = new System.Drawing.Point(6, 152);
            this.chk_setspeed.Name = "chk_setspeed";
            this.chk_setspeed.Size = new System.Drawing.Size(76, 17);
            this.chk_setspeed.TabIndex = 3;
            this.chk_setspeed.Text = "Set Speed";
            this.chk_setspeed.UseVisualStyleBackColor = true;
            // 
            // lbl_speed
            // 
            this.lbl_speed.AutoSize = true;
            this.lbl_speed.Location = new System.Drawing.Point(39, 175);
            this.lbl_speed.Name = "lbl_speed";
            this.lbl_speed.Size = new System.Drawing.Size(38, 13);
            this.lbl_speed.TabIndex = 2;
            this.lbl_speed.Text = "Speed";
            // 
            // txt_speed
            // 
            this.txt_speed.Location = new System.Drawing.Point(39, 194);
            this.txt_speed.Name = "txt_speed";
            this.txt_speed.Size = new System.Drawing.Size(100, 20);
            this.txt_speed.TabIndex = 1;
            // 
            // chk_config
            // 
            this.chk_config.AutoSize = true;
            this.chk_config.Location = new System.Drawing.Point(6, 127);
            this.chk_config.Name = "chk_config";
            this.chk_config.Size = new System.Drawing.Size(71, 17);
            this.chk_config.TabIndex = 0;
            this.chk_config.Text = "Configure";
            this.chk_config.UseVisualStyleBackColor = true;
            // 
            // Pump_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1070, 487);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Pump1_GrpBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Pump_Form";
            this.Pump1_GrpBox.ResumeLayout(false);
            this.grp_next.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Pump1_GrpBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pumpActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPumpToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.GroupBox grp_next;
        private System.Windows.Forms.Button btn_total_time;
        private System.Windows.Forms.Button btn_offtime;
        private System.Windows.Forms.Button btn_runtime;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_halt;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.CheckBox chk_setspeed;
        private System.Windows.Forms.Label lbl_speed;
        private System.Windows.Forms.TextBox txt_speed;
        private System.Windows.Forms.CheckBox chk_config;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_comport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_baud;
    }
}


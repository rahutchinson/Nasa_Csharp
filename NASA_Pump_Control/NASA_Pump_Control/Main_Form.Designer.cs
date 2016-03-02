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
            this.Pump1_GrpBox.SuspendLayout();
            this.grp_next.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.newPumpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newPumpToolStripMenuItem.Text = "New Pump";
            // 
            // Pump_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1070, 487);
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
    }
}


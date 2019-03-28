namespace AOIFileTransferToDiffFolder
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtTarget1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTarget2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timerTransfer = new System.Windows.Forms.Timer(this.components);
            this.txtTarget3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSouceQty = new System.Windows.Forms.Label();
            this.lblTargetQty1 = new System.Windows.Forms.Label();
            this.lblTargetQty2 = new System.Windows.Forms.Label();
            this.lblTargetQty3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "源文件夹：";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(101, 15);
            this.txtSource.Name = "txtSource";
            this.txtSource.ReadOnly = true;
            this.txtSource.Size = new System.Drawing.Size(384, 20);
            this.txtSource.TabIndex = 1;
            // 
            // txtTarget1
            // 
            this.txtTarget1.Location = new System.Drawing.Point(101, 51);
            this.txtTarget1.Name = "txtTarget1";
            this.txtTarget1.ReadOnly = true;
            this.txtTarget1.Size = new System.Drawing.Size(384, 20);
            this.txtTarget1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "目标文件夹1：";
            // 
            // txtTarget2
            // 
            this.txtTarget2.Location = new System.Drawing.Point(101, 89);
            this.txtTarget2.Name = "txtTarget2";
            this.txtTarget2.ReadOnly = true;
            this.txtTarget2.Size = new System.Drawing.Size(384, 20);
            this.txtTarget2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "目标文件夹2：";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Lime;
            this.btnStart.Location = new System.Drawing.Point(101, 183);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(78, 43);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "启用";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(407, 183);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(78, 43);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timerTransfer
            // 
            this.timerTransfer.Interval = 1000;
            this.timerTransfer.Tick += new System.EventHandler(this.timerTransfer_Tick);
            // 
            // txtTarget3
            // 
            this.txtTarget3.Location = new System.Drawing.Point(101, 126);
            this.txtTarget3.Name = "txtTarget3";
            this.txtTarget3.ReadOnly = true;
            this.txtTarget3.Size = new System.Drawing.Size(384, 20);
            this.txtTarget3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "目标文件夹3：";
            // 
            // lblSouceQty
            // 
            this.lblSouceQty.AutoSize = true;
            this.lblSouceQty.Location = new System.Drawing.Point(491, 18);
            this.lblSouceQty.Name = "lblSouceQty";
            this.lblSouceQty.Size = new System.Drawing.Size(13, 13);
            this.lblSouceQty.TabIndex = 10;
            this.lblSouceQty.Text = "0";
            // 
            // lblTargetQty1
            // 
            this.lblTargetQty1.AutoSize = true;
            this.lblTargetQty1.Location = new System.Drawing.Point(491, 54);
            this.lblTargetQty1.Name = "lblTargetQty1";
            this.lblTargetQty1.Size = new System.Drawing.Size(13, 13);
            this.lblTargetQty1.TabIndex = 11;
            this.lblTargetQty1.Text = "0";
            // 
            // lblTargetQty2
            // 
            this.lblTargetQty2.AutoSize = true;
            this.lblTargetQty2.Location = new System.Drawing.Point(491, 92);
            this.lblTargetQty2.Name = "lblTargetQty2";
            this.lblTargetQty2.Size = new System.Drawing.Size(13, 13);
            this.lblTargetQty2.TabIndex = 12;
            this.lblTargetQty2.Text = "0";
            // 
            // lblTargetQty3
            // 
            this.lblTargetQty3.AutoSize = true;
            this.lblTargetQty3.Location = new System.Drawing.Point(491, 129);
            this.lblTargetQty3.Name = "lblTargetQty3";
            this.lblTargetQty3.Size = new System.Drawing.Size(13, 13);
            this.lblTargetQty3.TabIndex = 13;
            this.lblTargetQty3.Text = "0";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(606, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 261);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblTargetQty3);
            this.Controls.Add(this.lblTargetQty2);
            this.Controls.Add(this.lblTargetQty1);
            this.Controls.Add(this.lblSouceQty);
            this.Controls.Add(this.txtTarget3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtTarget2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTarget1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "AOI OUTPUT FILE TRANSFER TOOL";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtTarget1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTarget2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timerTransfer;
        private System.Windows.Forms.TextBox txtTarget3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSouceQty;
        private System.Windows.Forms.Label lblTargetQty1;
        private System.Windows.Forms.Label lblTargetQty2;
        private System.Windows.Forms.Label lblTargetQty3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}
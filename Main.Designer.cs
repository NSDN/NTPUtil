namespace NTPUtil
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.GroupMain = new System.Windows.Forms.GroupBox();
            this.BoxUnlock = new System.Windows.Forms.CheckBox();
            this.BoxHigh = new System.Windows.Forms.CheckBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelDist = new System.Windows.Forms.Label();
            this.BoxDist = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelLim = new System.Windows.Forms.Label();
            this.BoxLim = new System.Windows.Forms.TextBox();
            this.LabelR = new System.Windows.Forms.Label();
            this.BoxR = new System.Windows.Forms.TextBox();
            this.LabelP = new System.Windows.Forms.Label();
            this.BoxP = new System.Windows.Forms.TextBox();
            this.LabelV = new System.Windows.Forms.Label();
            this.BoxV = new System.Windows.Forms.TextBox();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.Info = new System.Windows.Forms.ToolStripStatusLabel();
            this.GroupGraph = new System.Windows.Forms.GroupBox();
            this.BoxGraph = new System.Windows.Forms.PictureBox();
            this.GroupCode = new System.Windows.Forms.GroupBox();
            this.BoxCode = new System.Windows.Forms.TextBox();
            this.GroupMain.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.GroupGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxGraph)).BeginInit();
            this.GroupCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupMain
            // 
            this.GroupMain.Controls.Add(this.BoxUnlock);
            this.GroupMain.Controls.Add(this.BoxHigh);
            this.GroupMain.Controls.Add(this.BtnClear);
            this.GroupMain.Controls.Add(this.BtnCalc);
            this.GroupMain.Controls.Add(this.label5);
            this.GroupMain.Controls.Add(this.label4);
            this.GroupMain.Controls.Add(this.label3);
            this.GroupMain.Controls.Add(this.label2);
            this.GroupMain.Controls.Add(this.LabelDist);
            this.GroupMain.Controls.Add(this.BoxDist);
            this.GroupMain.Controls.Add(this.label1);
            this.GroupMain.Controls.Add(this.LabelLim);
            this.GroupMain.Controls.Add(this.BoxLim);
            this.GroupMain.Controls.Add(this.LabelR);
            this.GroupMain.Controls.Add(this.BoxR);
            this.GroupMain.Controls.Add(this.LabelP);
            this.GroupMain.Controls.Add(this.BoxP);
            this.GroupMain.Controls.Add(this.LabelV);
            this.GroupMain.Controls.Add(this.BoxV);
            this.GroupMain.Location = new System.Drawing.Point(12, 12);
            this.GroupMain.Name = "GroupMain";
            this.GroupMain.Size = new System.Drawing.Size(268, 202);
            this.GroupMain.TabIndex = 17;
            this.GroupMain.TabStop = false;
            this.GroupMain.Text = "数据";
            // 
            // BoxUnlock
            // 
            this.BoxUnlock.AutoSize = true;
            this.BoxUnlock.Enabled = false;
            this.BoxUnlock.Location = new System.Drawing.Point(8, 153);
            this.BoxUnlock.Name = "BoxUnlock";
            this.BoxUnlock.Size = new System.Drawing.Size(96, 16);
            this.BoxUnlock.TabIndex = 9;
            this.BoxUnlock.Text = "试验速度解锁";
            this.BoxUnlock.UseVisualStyleBackColor = true;
            // 
            // BoxHigh
            // 
            this.BoxHigh.AutoSize = true;
            this.BoxHigh.Location = new System.Drawing.Point(8, 175);
            this.BoxHigh.Name = "BoxHigh";
            this.BoxHigh.Size = new System.Drawing.Size(72, 16);
            this.BoxHigh.TabIndex = 5;
            this.BoxHigh.Text = "高速模式";
            this.BoxHigh.UseVisualStyleBackColor = true;
            this.BoxHigh.CheckedChanged += new System.EventHandler(this.BoxHigh_CheckedChanged);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(106, 171);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 6;
            this.BtnClear.Text = "清空输入";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnCalc
            // 
            this.BtnCalc.Location = new System.Drawing.Point(187, 171);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(75, 23);
            this.BtnCalc.TabIndex = 7;
            this.BtnCalc.Text = "开始计算";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(113, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 31;
            this.label5.Text = "单位 m";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(113, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 12);
            this.label4.TabIndex = 30;
            this.label4.Text = "不可为负值, 单位 m/tick";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(113, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 12);
            this.label3.TabIndex = 29;
            this.label3.Text = "正整数, 建议取值 0 到 9";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(113, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 12);
            this.label2.TabIndex = 28;
            this.label2.Text = "正整数, 建议取值 0 到 20";
            // 
            // LabelDist
            // 
            this.LabelDist.AutoSize = true;
            this.LabelDist.Location = new System.Drawing.Point(6, 125);
            this.LabelDist.Name = "LabelDist";
            this.LabelDist.Size = new System.Drawing.Size(53, 12);
            this.LabelDist.TabIndex = 27;
            this.LabelDist.Text = "运行距离";
            // 
            // BoxDist
            // 
            this.BoxDist.Location = new System.Drawing.Point(65, 122);
            this.BoxDist.Name = "BoxDist";
            this.BoxDist.ReadOnly = true;
            this.BoxDist.Size = new System.Drawing.Size(42, 21);
            this.BoxDist.TabIndex = 4;
            this.BoxDist.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(113, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "不可为负值, 单位 m/tick";
            // 
            // LabelLim
            // 
            this.LabelLim.AutoSize = true;
            this.LabelLim.Location = new System.Drawing.Point(6, 98);
            this.LabelLim.Name = "LabelLim";
            this.LabelLim.Size = new System.Drawing.Size(53, 12);
            this.LabelLim.TabIndex = 24;
            this.LabelLim.Text = "目标速率";
            // 
            // BoxLim
            // 
            this.BoxLim.Location = new System.Drawing.Point(65, 95);
            this.BoxLim.Name = "BoxLim";
            this.BoxLim.Size = new System.Drawing.Size(42, 21);
            this.BoxLim.TabIndex = 3;
            this.BoxLim.Tag = "";
            // 
            // LabelR
            // 
            this.LabelR.AutoSize = true;
            this.LabelR.Location = new System.Drawing.Point(6, 71);
            this.LabelR.Name = "LabelR";
            this.LabelR.Size = new System.Drawing.Size(53, 12);
            this.LabelR.TabIndex = 22;
            this.LabelR.Text = "设定制动";
            // 
            // BoxR
            // 
            this.BoxR.Location = new System.Drawing.Point(65, 68);
            this.BoxR.Name = "BoxR";
            this.BoxR.Size = new System.Drawing.Size(42, 21);
            this.BoxR.TabIndex = 2;
            this.BoxR.Tag = "";
            // 
            // LabelP
            // 
            this.LabelP.AutoSize = true;
            this.LabelP.Location = new System.Drawing.Point(6, 44);
            this.LabelP.Name = "LabelP";
            this.LabelP.Size = new System.Drawing.Size(53, 12);
            this.LabelP.TabIndex = 20;
            this.LabelP.Text = "设定功率";
            // 
            // BoxP
            // 
            this.BoxP.Location = new System.Drawing.Point(65, 41);
            this.BoxP.Name = "BoxP";
            this.BoxP.Size = new System.Drawing.Size(42, 21);
            this.BoxP.TabIndex = 1;
            this.BoxP.Tag = "";
            // 
            // LabelV
            // 
            this.LabelV.AutoSize = true;
            this.LabelV.Location = new System.Drawing.Point(6, 17);
            this.LabelV.Name = "LabelV";
            this.LabelV.Size = new System.Drawing.Size(53, 12);
            this.LabelV.TabIndex = 18;
            this.LabelV.Text = "初始速率";
            // 
            // BoxV
            // 
            this.BoxV.Location = new System.Drawing.Point(65, 14);
            this.BoxV.Name = "BoxV";
            this.BoxV.Size = new System.Drawing.Size(42, 21);
            this.BoxV.TabIndex = 0;
            this.BoxV.Tag = "";
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Info});
            this.StatusBar.Location = new System.Drawing.Point(0, 567);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(832, 22);
            this.StatusBar.TabIndex = 18;
            this.StatusBar.Text = "Status";
            // 
            // Info
            // 
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(117, 17);
            this.Info.Text = "NSDN-MC © 2018";
            // 
            // GroupGraph
            // 
            this.GroupGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupGraph.Controls.Add(this.BoxGraph);
            this.GroupGraph.Location = new System.Drawing.Point(294, 12);
            this.GroupGraph.Name = "GroupGraph";
            this.GroupGraph.Size = new System.Drawing.Size(524, 544);
            this.GroupGraph.TabIndex = 19;
            this.GroupGraph.TabStop = false;
            this.GroupGraph.Text = "图像 (速率 - 时间曲线)";
            // 
            // BoxGraph
            // 
            this.BoxGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxGraph.ErrorImage = null;
            this.BoxGraph.InitialImage = null;
            this.BoxGraph.Location = new System.Drawing.Point(6, 20);
            this.BoxGraph.Name = "BoxGraph";
            this.BoxGraph.Size = new System.Drawing.Size(512, 512);
            this.BoxGraph.TabIndex = 0;
            this.BoxGraph.TabStop = false;
            // 
            // GroupCode
            // 
            this.GroupCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GroupCode.Controls.Add(this.BoxCode);
            this.GroupCode.Location = new System.Drawing.Point(12, 220);
            this.GroupCode.Name = "GroupCode";
            this.GroupCode.Size = new System.Drawing.Size(268, 336);
            this.GroupCode.TabIndex = 20;
            this.GroupCode.TabStop = false;
            this.GroupCode.Text = "代码";
            // 
            // BoxCode
            // 
            this.BoxCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BoxCode.Font = new System.Drawing.Font("宋体", 9F);
            this.BoxCode.Location = new System.Drawing.Point(6, 20);
            this.BoxCode.Multiline = true;
            this.BoxCode.Name = "BoxCode";
            this.BoxCode.ReadOnly = true;
            this.BoxCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BoxCode.Size = new System.Drawing.Size(256, 304);
            this.BoxCode.TabIndex = 8;
            // 
            // Main
            // 
            this.AcceptButton = this.BtnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 589);
            this.Controls.Add(this.GroupCode);
            this.Controls.Add(this.GroupGraph);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.GroupMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(848, 628);
            this.MinimumSize = new System.Drawing.Size(308, 400);
            this.Name = "Main";
            this.Text = "NTPUtil";
            this.Load += new System.EventHandler(this.Main_Load);
            this.GroupMain.ResumeLayout(false);
            this.GroupMain.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.GroupGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BoxGraph)).EndInit();
            this.GroupCode.ResumeLayout(false);
            this.GroupCode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupMain;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelDist;
        private System.Windows.Forms.TextBox BoxDist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelLim;
        private System.Windows.Forms.TextBox BoxLim;
        private System.Windows.Forms.Label LabelR;
        private System.Windows.Forms.TextBox BoxR;
        private System.Windows.Forms.Label LabelP;
        private System.Windows.Forms.TextBox BoxP;
        private System.Windows.Forms.Label LabelV;
        private System.Windows.Forms.TextBox BoxV;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel Info;
        private System.Windows.Forms.GroupBox GroupGraph;
        private System.Windows.Forms.PictureBox BoxGraph;
        private System.Windows.Forms.CheckBox BoxHigh;
        private System.Windows.Forms.GroupBox GroupCode;
        private System.Windows.Forms.TextBox BoxCode;
        private System.Windows.Forms.CheckBox BoxUnlock;
    }
}


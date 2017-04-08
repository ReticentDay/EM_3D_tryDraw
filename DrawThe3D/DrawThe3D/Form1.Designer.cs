namespace DrawThe3D
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.DisplayScreen = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objectList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.setBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLong = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.setBoxX = new System.Windows.Forms.TextBox();
            this.setBoxY = new System.Windows.Forms.TextBox();
            this.setBoxZ = new System.Windows.Forms.TextBox();
            this.setBoxHeight = new System.Windows.Forms.TextBox();
            this.setBoxWeight = new System.Windows.Forms.TextBox();
            this.setBoxLong = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.setBoxTurnX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.setBoxTurnY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.setBoxTurnZ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayScreen)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayScreen
            // 
            this.DisplayScreen.Location = new System.Drawing.Point(12, 27);
            this.DisplayScreen.Name = "DisplayScreen";
            this.DisplayScreen.Size = new System.Drawing.Size(800, 400);
            this.DisplayScreen.TabIndex = 0;
            this.DisplayScreen.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aDDToolStripMenuItem
            // 
            this.aDDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointToolStripMenuItem,
            this.lineToolStripMenuItem,
            this.rectangleToolStripMenuItem,
            this.boxToolStripMenuItem});
            this.aDDToolStripMenuItem.Name = "aDDToolStripMenuItem";
            this.aDDToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.aDDToolStripMenuItem.Text = "add";
            this.aDDToolStripMenuItem.Click += new System.EventHandler(this.aDDToolStripMenuItem_Click);
            // 
            // pointToolStripMenuItem
            // 
            this.pointToolStripMenuItem.Name = "pointToolStripMenuItem";
            this.pointToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pointToolStripMenuItem.Text = "point";
            this.pointToolStripMenuItem.Click += new System.EventHandler(this.pointToolStripMenuItem_Click);
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lineToolStripMenuItem.Text = "line";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rectangleToolStripMenuItem.Text = "rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // boxToolStripMenuItem
            // 
            this.boxToolStripMenuItem.Name = "boxToolStripMenuItem";
            this.boxToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.boxToolStripMenuItem.Text = "box";
            this.boxToolStripMenuItem.Click += new System.EventHandler(this.boxToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.aboutToolStripMenuItem.Text = "about";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // objectList
            // 
            this.objectList.FormattingEnabled = true;
            this.objectList.ItemHeight = 12;
            this.objectList.Location = new System.Drawing.Point(12, 433);
            this.objectList.Name = "objectList";
            this.objectList.Size = new System.Drawing.Size(218, 196);
            this.objectList.TabIndex = 3;
            this.objectList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "X：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Z：";
            // 
            // setBoxName
            // 
            this.setBoxName.Location = new System.Drawing.Point(292, 433);
            this.setBoxName.Name = "setBoxName";
            this.setBoxName.Size = new System.Drawing.Size(100, 22);
            this.setBoxName.TabIndex = 11;
            this.setBoxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(242, 436);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 12);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Name：";
            // 
            // labelLong
            // 
            this.labelLong.AutoSize = true;
            this.labelLong.Location = new System.Drawing.Point(242, 606);
            this.labelLong.Name = "labelLong";
            this.labelLong.Size = new System.Drawing.Size(42, 12);
            this.labelLong.TabIndex = 16;
            this.labelLong.Text = "Long：";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(241, 578);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(51, 12);
            this.labelWeight.TabIndex = 14;
            this.labelWeight.Text = "Weight：";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(242, 550);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(48, 12);
            this.labelHeight.TabIndex = 12;
            this.labelHeight.Text = "Height：";
            // 
            // setBoxX
            // 
            this.setBoxX.Location = new System.Drawing.Point(292, 461);
            this.setBoxX.Name = "setBoxX";
            this.setBoxX.Size = new System.Drawing.Size(100, 22);
            this.setBoxX.TabIndex = 5;
            this.setBoxX.TextChanged += new System.EventHandler(this.setBoxX_TextChanged);
            // 
            // setBoxY
            // 
            this.setBoxY.Location = new System.Drawing.Point(292, 489);
            this.setBoxY.Name = "setBoxY";
            this.setBoxY.Size = new System.Drawing.Size(100, 22);
            this.setBoxY.TabIndex = 7;
            this.setBoxY.TextChanged += new System.EventHandler(this.setBoxY_TextChanged);
            // 
            // setBoxZ
            // 
            this.setBoxZ.Location = new System.Drawing.Point(292, 517);
            this.setBoxZ.Name = "setBoxZ";
            this.setBoxZ.Size = new System.Drawing.Size(100, 22);
            this.setBoxZ.TabIndex = 9;
            this.setBoxZ.TextChanged += new System.EventHandler(this.setBoxZ_TextChanged);
            // 
            // setBoxHeight
            // 
            this.setBoxHeight.Location = new System.Drawing.Point(292, 547);
            this.setBoxHeight.Name = "setBoxHeight";
            this.setBoxHeight.Size = new System.Drawing.Size(100, 22);
            this.setBoxHeight.TabIndex = 13;
            this.setBoxHeight.TextChanged += new System.EventHandler(this.setBoxHeight_TextChanged);
            // 
            // setBoxWeight
            // 
            this.setBoxWeight.Location = new System.Drawing.Point(292, 575);
            this.setBoxWeight.Name = "setBoxWeight";
            this.setBoxWeight.Size = new System.Drawing.Size(100, 22);
            this.setBoxWeight.TabIndex = 15;
            this.setBoxWeight.TextChanged += new System.EventHandler(this.setBoxWeight_TextChanged);
            // 
            // setBoxLong
            // 
            this.setBoxLong.Location = new System.Drawing.Point(292, 603);
            this.setBoxLong.Name = "setBoxLong";
            this.setBoxLong.Size = new System.Drawing.Size(100, 22);
            this.setBoxLong.TabIndex = 17;
            this.setBoxLong.TextChanged += new System.EventHandler(this.setBoxLong_TextChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(398, 461);
            this.trackBar1.Maximum = 360;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(425, 45);
            this.trackBar1.TabIndex = 18;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // setBoxTurnX
            // 
            this.setBoxTurnX.Location = new System.Drawing.Point(454, 433);
            this.setBoxTurnX.Name = "setBoxTurnX";
            this.setBoxTurnX.Size = new System.Drawing.Size(100, 22);
            this.setBoxTurnX.TabIndex = 20;
            this.setBoxTurnX.TextChanged += new System.EventHandler(this.setBoxTurnX_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "TrunX：";
            // 
            // setBoxTurnY
            // 
            this.setBoxTurnY.Location = new System.Drawing.Point(454, 496);
            this.setBoxTurnY.Name = "setBoxTurnY";
            this.setBoxTurnY.Size = new System.Drawing.Size(100, 22);
            this.setBoxTurnY.TabIndex = 23;
            this.setBoxTurnY.TextChanged += new System.EventHandler(this.setBoxTurnY_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "TrunY：";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(398, 524);
            this.trackBar2.Maximum = 360;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(425, 45);
            this.trackBar2.TabIndex = 21;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // setBoxTurnZ
            // 
            this.setBoxTurnZ.Location = new System.Drawing.Point(454, 556);
            this.setBoxTurnZ.Name = "setBoxTurnZ";
            this.setBoxTurnZ.Size = new System.Drawing.Size(100, 22);
            this.setBoxTurnZ.TabIndex = 26;
            this.setBoxTurnZ.TextChanged += new System.EventHandler(this.setBoxTurnZ_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 559);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "TrunZ：";
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(400, 584);
            this.trackBar3.Maximum = 360;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(425, 45);
            this.trackBar3.TabIndex = 24;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 637);
            this.Controls.Add(this.setBoxTurnZ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.setBoxTurnY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.setBoxTurnX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.setBoxLong);
            this.Controls.Add(this.labelLong);
            this.Controls.Add(this.setBoxWeight);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.setBoxHeight);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.setBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.setBoxZ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.setBoxY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.setBoxX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.objectList);
            this.Controls.Add(this.DisplayScreen);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DisplayScreen)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DisplayScreen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListBox objectList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox setBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLong;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox setBoxX;
        private System.Windows.Forms.TextBox setBoxY;
        private System.Windows.Forms.TextBox setBoxZ;
        private System.Windows.Forms.TextBox setBoxHeight;
        private System.Windows.Forms.TextBox setBoxWeight;
        private System.Windows.Forms.TextBox setBoxLong;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox setBoxTurnX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox setBoxTurnY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TextBox setBoxTurnZ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar3;
    }
}


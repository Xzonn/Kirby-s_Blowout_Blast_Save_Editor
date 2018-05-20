namespace KirbyBlowoutBlastSaveEditor
{
    partial class KirbyBlowoutBlastSaveEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KirbyBlowoutBlastSaveEditor));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.openItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutLabel = new System.Windows.Forms.LinkLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.levelGroup = new System.Windows.Forms.GroupBox();
            this.trophyLabel = new System.Windows.Forms.Label();
            this.scoreLabel3 = new System.Windows.Forms.Label();
            this.scoreLabel2 = new System.Windows.Forms.Label();
            this.scoreLabel1 = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.trophyBox = new System.Windows.Forms.ComboBox();
            this.scoreBox3 = new System.Windows.Forms.NumericUpDown();
            this.scoreBox2 = new System.Windows.Forms.NumericUpDown();
            this.scoreBox1 = new System.Windows.Forms.NumericUpDown();
            this.levelBox = new System.Windows.Forms.ComboBox();
            this.amiiboGroup = new System.Windows.Forms.GroupBox();
            this.amiiboBox = new System.Windows.Forms.CheckedListBox();
            this.lastLevelLabel = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.levelGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBox1)).BeginInit();
            this.amiiboGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.DereferenceLinks = false;
            this.openFileDialog.Filter = "存档文件|*.dat|所有文件|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "存档文件|*.dat|所有文件|*.*";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openItem,
            this.saveItem,
            this.aboutItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(284, 25);
            this.menuStrip.TabIndex = 0;
            // 
            // openItem
            // 
            this.openItem.Name = "openItem";
            this.openItem.Size = new System.Drawing.Size(90, 21);
            this.openItem.Text = "打开文件 (&O)";
            this.openItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // saveItem
            // 
            this.saveItem.Enabled = false;
            this.saveItem.Name = "saveItem";
            this.saveItem.Size = new System.Drawing.Size(87, 21);
            this.saveItem.Text = "保存文件 (&S)";
            this.saveItem.Click += new System.EventHandler(this.SaveFile);
            // 
            // aboutItem
            // 
            this.aboutItem.Name = "aboutItem";
            this.aboutItem.Size = new System.Drawing.Size(64, 21);
            this.aboutItem.Text = "关于 (&A)";
            this.aboutItem.Click += new System.EventHandler(this.AboutClick);
            // 
            // aboutLabel
            // 
            this.aboutLabel.AccessibleName = "";
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.aboutLabel.Location = new System.Drawing.Point(192, 365);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(80, 17);
            this.aboutLabel.TabIndex = 4;
            this.aboutLabel.TabStop = true;
            this.aboutLabel.Text = "制作：Xzonn";
            this.aboutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AboutClick);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 389);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(284, 22);
            this.statusStrip.TabIndex = 14;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(104, 17);
            this.statusLabel.Text = "未打开存档文件。";
            // 
            // levelGroup
            // 
            this.levelGroup.Controls.Add(this.trophyLabel);
            this.levelGroup.Controls.Add(this.scoreLabel3);
            this.levelGroup.Controls.Add(this.scoreLabel2);
            this.levelGroup.Controls.Add(this.scoreLabel1);
            this.levelGroup.Controls.Add(this.levelLabel);
            this.levelGroup.Controls.Add(this.trophyBox);
            this.levelGroup.Controls.Add(this.scoreBox3);
            this.levelGroup.Controls.Add(this.scoreBox2);
            this.levelGroup.Controls.Add(this.scoreBox1);
            this.levelGroup.Controls.Add(this.levelBox);
            this.levelGroup.Enabled = false;
            this.levelGroup.Location = new System.Drawing.Point(9, 29);
            this.levelGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.levelGroup.Name = "levelGroup";
            this.levelGroup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.levelGroup.Size = new System.Drawing.Size(263, 196);
            this.levelGroup.TabIndex = 1;
            this.levelGroup.TabStop = false;
            this.levelGroup.Text = "关卡";
            // 
            // trophyLabel
            // 
            this.trophyLabel.Location = new System.Drawing.Point(9, 159);
            this.trophyLabel.Name = "trophyLabel";
            this.trophyLabel.Size = new System.Drawing.Size(80, 25);
            this.trophyLabel.TabIndex = 10;
            this.trophyLabel.Text = "奖杯：";
            this.trophyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // scoreLabel3
            // 
            this.scoreLabel3.Location = new System.Drawing.Point(9, 124);
            this.scoreLabel3.Name = "scoreLabel3";
            this.scoreLabel3.Size = new System.Drawing.Size(80, 23);
            this.scoreLabel3.TabIndex = 8;
            this.scoreLabel3.Text = "第三名：";
            this.scoreLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // scoreLabel2
            // 
            this.scoreLabel2.Location = new System.Drawing.Point(9, 89);
            this.scoreLabel2.Name = "scoreLabel2";
            this.scoreLabel2.Size = new System.Drawing.Size(80, 23);
            this.scoreLabel2.TabIndex = 6;
            this.scoreLabel2.Text = "第二名：";
            this.scoreLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // scoreLabel1
            // 
            this.scoreLabel1.Location = new System.Drawing.Point(9, 54);
            this.scoreLabel1.Name = "scoreLabel1";
            this.scoreLabel1.Size = new System.Drawing.Size(80, 23);
            this.scoreLabel1.TabIndex = 4;
            this.scoreLabel1.Text = "第一名：";
            this.scoreLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // levelLabel
            // 
            this.levelLabel.Location = new System.Drawing.Point(9, 19);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(80, 25);
            this.levelLabel.TabIndex = 2;
            this.levelLabel.Text = "关卡选择：";
            this.levelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trophyBox
            // 
            this.trophyBox.FormattingEnabled = true;
            this.trophyBox.Items.AddRange(new object[] {
            "铜",
            "银",
            "金",
            "白金"});
            this.trophyBox.Location = new System.Drawing.Point(94, 159);
            this.trophyBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trophyBox.Name = "trophyBox";
            this.trophyBox.Size = new System.Drawing.Size(163, 25);
            this.trophyBox.TabIndex = 11;
            this.trophyBox.Text = "铜";
            // 
            // scoreBox3
            // 
            this.scoreBox3.Location = new System.Drawing.Point(94, 124);
            this.scoreBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scoreBox3.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.scoreBox3.Name = "scoreBox3";
            this.scoreBox3.Size = new System.Drawing.Size(163, 23);
            this.scoreBox3.TabIndex = 9;
            this.scoreBox3.Leave += new System.EventHandler(this.ScoreChange);
            // 
            // scoreBox2
            // 
            this.scoreBox2.Location = new System.Drawing.Point(94, 89);
            this.scoreBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scoreBox2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.scoreBox2.Name = "scoreBox2";
            this.scoreBox2.Size = new System.Drawing.Size(163, 23);
            this.scoreBox2.TabIndex = 7;
            this.scoreBox2.Leave += new System.EventHandler(this.ScoreChange);
            // 
            // scoreBox1
            // 
            this.scoreBox1.Location = new System.Drawing.Point(94, 54);
            this.scoreBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scoreBox1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.scoreBox1.Name = "scoreBox1";
            this.scoreBox1.Size = new System.Drawing.Size(163, 23);
            this.scoreBox1.TabIndex = 5;
            this.scoreBox1.Leave += new System.EventHandler(this.ScoreChange);
            // 
            // levelBox
            // 
            this.levelBox.FormattingEnabled = true;
            this.levelBox.Items.AddRange(new object[] {
            "1-1",
            "1-2",
            "1-3",
            "1-4",
            "2-1",
            "2-2",
            "2-3",
            "2-4",
            "3-1",
            "3-2",
            "3-3",
            "3-4",
            "3-5",
            "4-1",
            "4-2",
            "4-3",
            "4-4",
            "4-5",
            "5-1",
            "5-2",
            "5-3",
            "5-4",
            "5-5",
            "1-1 (EX)",
            "1-2 (EX)",
            "1-3 (EX)",
            "1-4 (EX)",
            "2-1 (EX)",
            "2-2 (EX)",
            "2-3 (EX)",
            "2-4 (EX)",
            "3-1 (EX)",
            "3-2 (EX)",
            "3-3 (EX)",
            "3-4 (EX)",
            "3-5 (EX)",
            "4-1 (EX)",
            "4-2 (EX)",
            "4-3 (EX)",
            "4-4 (EX)",
            "4-5 (EX)",
            "5-1 (EX)",
            "5-2 (EX)",
            "5-3 (EX)",
            "5-4 (EX)",
            "5-5 (EX)"});
            this.levelBox.Location = new System.Drawing.Point(94, 19);
            this.levelBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.levelBox.Name = "levelBox";
            this.levelBox.Size = new System.Drawing.Size(163, 25);
            this.levelBox.TabIndex = 3;
            this.levelBox.Text = "1-1";
            this.levelBox.SelectedIndexChanged += new System.EventHandler(this.LevelChange);
            // 
            // amiiboGroup
            // 
            this.amiiboGroup.Controls.Add(this.amiiboBox);
            this.amiiboGroup.Enabled = false;
            this.amiiboGroup.Location = new System.Drawing.Point(9, 233);
            this.amiiboGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.amiiboGroup.Name = "amiiboGroup";
            this.amiiboGroup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.amiiboGroup.Size = new System.Drawing.Size(263, 128);
            this.amiiboGroup.TabIndex = 12;
            this.amiiboGroup.TabStop = false;
            this.amiiboGroup.Text = "Amiibo";
            // 
            // amiiboBox
            // 
            this.amiiboBox.FormattingEnabled = true;
            this.amiiboBox.Items.AddRange(new object[] {
            "解锁罗卜卜机甲和苏茜雕像",
            "解锁卡比雕像",
            "解锁魅塔骑士雕像",
            "解锁帝帝帝大王雕像",
            "解锁瓦豆鲁迪雕像"});
            this.amiiboBox.Location = new System.Drawing.Point(6, 24);
            this.amiiboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.amiiboBox.Name = "amiiboBox";
            this.amiiboBox.Size = new System.Drawing.Size(251, 94);
            this.amiiboBox.TabIndex = 13;
            // 
            // lastLevelLabel
            // 
            this.lastLevelLabel.Location = new System.Drawing.Point(0, 0);
            this.lastLevelLabel.Name = "lastLevelLabel";
            this.lastLevelLabel.Size = new System.Drawing.Size(100, 23);
            this.lastLevelLabel.TabIndex = 0;
            this.lastLevelLabel.Text = "1-1";
            this.lastLevelLabel.Visible = false;
            // 
            // KirbyBlowoutBlastSaveEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.lastLevelLabel);
            this.Controls.Add(this.aboutLabel);
            this.Controls.Add(this.amiiboGroup);
            this.Controls.Add(this.levelGroup);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "KirbyBlowoutBlastSaveEditor";
            this.Text = "卡比的吸入大作战 存档修改器";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.levelGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scoreBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBox1)).EndInit();
            this.amiiboGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem openItem;
        private System.Windows.Forms.ToolStripMenuItem saveItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.GroupBox levelGroup;
        private System.Windows.Forms.ComboBox levelBox;
        private System.Windows.Forms.NumericUpDown scoreBox1;
        private System.Windows.Forms.NumericUpDown scoreBox2;
        private System.Windows.Forms.NumericUpDown scoreBox3;
        private System.Windows.Forms.ComboBox trophyBox;
        private System.Windows.Forms.GroupBox amiiboGroup;
        private System.Windows.Forms.CheckedListBox amiiboBox;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.LinkLabel aboutLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutItem;
        private System.Windows.Forms.Label trophyLabel;
        private System.Windows.Forms.Label scoreLabel3;
        private System.Windows.Forms.Label scoreLabel2;
        private System.Windows.Forms.Label scoreLabel1;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label lastLevelLabel;
    }
}


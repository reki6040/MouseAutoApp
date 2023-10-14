namespace MouseAutoApp
{
    partial class Form
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BootOnOff = new System.Windows.Forms.Button();
            this.OneMiniteTimer = new System.Windows.Forms.Timer(this.components);
            this.TimeIntervalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.MenuRight = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // BootOnOff
            // 
            this.BootOnOff.Location = new System.Drawing.Point(266, 22);
            this.BootOnOff.Name = "BootOnOff";
            this.BootOnOff.Size = new System.Drawing.Size(101, 23);
            this.BootOnOff.TabIndex = 0;
            this.BootOnOff.Text = "Boot ON/OFF";
            this.BootOnOff.UseVisualStyleBackColor = true;
            this.BootOnOff.Click += new System.EventHandler(this.BootOnOff_Click);
            // 
            // OneMiniteTimer
            // 
            this.OneMiniteTimer.Interval = 60000;
            this.OneMiniteTimer.Tick += new System.EventHandler(this.OneMiniteTimer_Tick);
            // 
            // TimeIntervalTextBox
            // 
            this.TimeIntervalTextBox.Location = new System.Drawing.Point(147, 22);
            this.TimeIntervalTextBox.Name = "TimeIntervalTextBox";
            this.TimeIntervalTextBox.Size = new System.Drawing.Size(100, 19);
            this.TimeIntervalTextBox.TabIndex = 1;
            this.TimeIntervalTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeIntervalTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Time Interval[ms]";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 48);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(379, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 24);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(379, 24);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // MenuRight
            // 
            this.MenuRight.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.MenuRight.Location = new System.Drawing.Point(0, 0);
            this.MenuRight.Name = "MenuRight";
            this.MenuRight.Size = new System.Drawing.Size(379, 24);
            this.MenuRight.TabIndex = 6;
            this.MenuRight.Text = "Help";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.versionToolStripMenuItem.Text = "Version";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 55);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeIntervalTextBox);
            this.Controls.Add(this.BootOnOff);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.MenuRight);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form";
            this.Text = "MouseAutoApp";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.MenuRight.ResumeLayout(false);
            this.MenuRight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BootOnOff;
        private System.Windows.Forms.Timer OneMiniteTimer;
        private System.Windows.Forms.TextBox TimeIntervalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip MenuRight;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
    }
}


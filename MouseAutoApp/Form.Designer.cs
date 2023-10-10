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
            this.SuspendLayout();
            // 
            // BootOnOff
            // 
            this.BootOnOff.Location = new System.Drawing.Point(260, 48);
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
            this.TimeIntervalTextBox.Location = new System.Drawing.Point(139, 55);
            this.TimeIntervalTextBox.Name = "TimeIntervalTextBox";
            this.TimeIntervalTextBox.Size = new System.Drawing.Size(100, 19);
            this.TimeIntervalTextBox.TabIndex = 1;
            this.TimeIntervalTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeIntervalTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Time Interval[ms]";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 88);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeIntervalTextBox);
            this.Controls.Add(this.BootOnOff);
            this.Name = "Form";
            this.Text = "MouseAutoApp";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BootOnOff;
        private System.Windows.Forms.Timer OneMiniteTimer;
        private System.Windows.Forms.TextBox TimeIntervalTextBox;
        private System.Windows.Forms.Label label1;
    }
}


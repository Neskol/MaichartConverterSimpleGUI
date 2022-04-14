using System.Windows.Forms;

namespace MaichartConverterSimpleGUI
{
    partial class MainForm : Form
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ma2Box = new System.Windows.Forms.GroupBox();
            this.ma2TextBox = new System.Windows.Forms.TextBox();
            this.simaiBox = new System.Windows.Forms.GroupBox();
            this.simaiTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.ma2Box.SuspendLayout();
            this.simaiBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 616);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1090, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ma2Box
            // 
            this.ma2Box.Controls.Add(this.ma2TextBox);
            this.ma2Box.Location = new System.Drawing.Point(36, 103);
            this.ma2Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ma2Box.Name = "ma2Box";
            this.ma2Box.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ma2Box.Size = new System.Drawing.Size(342, 469);
            this.ma2Box.TabIndex = 1;
            this.ma2Box.TabStop = false;
            this.ma2Box.Text = "MA2 goes here";
            // 
            // ma2TextBox
            // 
            this.ma2TextBox.AcceptsReturn = true;
            this.ma2TextBox.AcceptsTab = true;
            this.ma2TextBox.AllowDrop = true;
            this.ma2TextBox.Location = new System.Drawing.Point(7, 31);
            this.ma2TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ma2TextBox.MaxLength = 22232767;
            this.ma2TextBox.Multiline = true;
            this.ma2TextBox.Name = "ma2TextBox";
            this.ma2TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ma2TextBox.Size = new System.Drawing.Size(314, 428);
            this.ma2TextBox.TabIndex = 0;
            // 
            // simaiBox
            // 
            this.simaiBox.Controls.Add(this.simaiTextBox);
            this.simaiBox.Location = new System.Drawing.Point(556, 103);
            this.simaiBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simaiBox.Name = "simaiBox";
            this.simaiBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simaiBox.Size = new System.Drawing.Size(498, 469);
            this.simaiBox.TabIndex = 2;
            this.simaiBox.TabStop = false;
            this.simaiBox.Text = "Simai goes here";
            // 
            // simaiTextBox
            // 
            this.simaiTextBox.AcceptsReturn = true;
            this.simaiTextBox.AcceptsTab = true;
            this.simaiTextBox.AllowDrop = true;
            this.simaiTextBox.Location = new System.Drawing.Point(7, 24);
            this.simaiTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simaiTextBox.MaxLength = 22232767;
            this.simaiTextBox.Multiline = true;
            this.simaiTextBox.Name = "simaiTextBox";
            this.simaiTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.simaiTextBox.Size = new System.Drawing.Size(483, 428);
            this.simaiTextBox.TabIndex = 1;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(398, 290);
            this.convertButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(135, 133);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert to -->";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 638);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.simaiBox);
            this.Controls.Add(this.ma2Box);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "MaichartConverter Simple GUI by Neskol";
            this.ma2Box.ResumeLayout(false);
            this.ma2Box.PerformLayout();
            this.simaiBox.ResumeLayout(false);
            this.simaiBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox ma2Box;
        private System.Windows.Forms.TextBox ma2TextBox;
        private System.Windows.Forms.GroupBox simaiBox;
        private System.Windows.Forms.TextBox simaiTextBox;
        private System.Windows.Forms.Button convertButton;
    }
}


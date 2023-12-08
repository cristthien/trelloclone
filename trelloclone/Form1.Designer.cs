using System.Windows.Forms;
using ui;

namespace trelloclone
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.myTablePanel = new System.Windows.Forms.Panel();
            this.myTableButton = new ui.RJButton();
            this.WorkSpacePanel = new System.Windows.Forms.Panel();
            this.timerMyTable = new System.Windows.Forms.Timer(this.components);
            this.myTablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 45);
            this.panel1.TabIndex = 0;
            // 
            // myTablePanel
            // 
            this.myTablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myTablePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(51)))), ((int)(((byte)(109)))));
            this.myTablePanel.Controls.Add(this.myTableButton);
            this.myTablePanel.Location = new System.Drawing.Point(0, 45);
            this.myTablePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myTablePanel.Name = "myTablePanel";
            this.myTablePanel.Size = new System.Drawing.Size(300, 800);
            this.myTablePanel.TabIndex = 1;
            // 
            // myTableButton
            // 
            this.myTableButton.BackColor = System.Drawing.Color.Transparent;
            this.myTableButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.myTableButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myTableButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.myTableButton.BorderRadius = 0;
            this.myTableButton.BorderSize = 0;
            this.myTableButton.FlatAppearance.BorderSize = 0;
            this.myTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myTableButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.myTableButton.ForeColor = System.Drawing.Color.White;
            this.myTableButton.Image = global::trelloclone.Properties.Resources.cross;
            this.myTableButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.myTableButton.Location = new System.Drawing.Point(25, 0);
            this.myTableButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myTableButton.Name = "myTableButton";
            this.myTableButton.Size = new System.Drawing.Size(250, 50);
            this.myTableButton.TabIndex = 0;
            this.myTableButton.Text = "Các bảng của bạn\r\n";
            this.myTableButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myTableButton.TextColor = System.Drawing.Color.White;
            this.myTableButton.UseVisualStyleBackColor = false;
            // 
            // WorkSpacePanel
            // 
            this.WorkSpacePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkSpacePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(76)))));
            this.WorkSpacePanel.Location = new System.Drawing.Point(300, 45);
            this.WorkSpacePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WorkSpacePanel.Name = "WorkSpacePanel";
            this.WorkSpacePanel.Size = new System.Drawing.Size(1400, 800);
            this.WorkSpacePanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 681);
            this.Controls.Add(this.WorkSpacePanel);
            this.Controls.Add(this.myTablePanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.myTablePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel myTablePanel;
        private Panel WorkSpacePanel;
        private RJButton myTableButton;
        private System.Windows.Forms.Timer timerMyTable;
    }
}
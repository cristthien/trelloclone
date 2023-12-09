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
            this.WorkSpacePanel = new System.Windows.Forms.Panel();
            this.timerMyTable = new System.Windows.Forms.Timer(this.components);
            this.sizeBar = new System.Windows.Forms.FlowLayoutPanel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.iconButton = new ui.RJButton();
            this.myTablePanel = new System.Windows.Forms.Panel();
            this.myTableButton = new ui.RJButton();
            this.sizeBar.SuspendLayout();
            this.menuPanel.SuspendLayout();
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
            // WorkSpacePanel
            // 
            this.WorkSpacePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkSpacePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(129)))), ((int)(((byte)(217)))));
            this.WorkSpacePanel.Location = new System.Drawing.Point(70, 45);
            this.WorkSpacePanel.Margin = new System.Windows.Forms.Padding(0);
            this.WorkSpacePanel.Name = "WorkSpacePanel";
            this.WorkSpacePanel.Size = new System.Drawing.Size(1621, 800);
            this.WorkSpacePanel.TabIndex = 2;
            // 
            // sizeBar
            // 
            this.sizeBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(85)))), ((int)(((byte)(186)))));
            this.sizeBar.Controls.Add(this.menuPanel);
            this.sizeBar.Controls.Add(this.myTablePanel);
            this.sizeBar.Location = new System.Drawing.Point(0, 45);
            this.sizeBar.Margin = new System.Windows.Forms.Padding(0);
            this.sizeBar.MaximumSize = new System.Drawing.Size(300, 1000);
            this.sizeBar.MinimumSize = new System.Drawing.Size(70, 1000);
            this.sizeBar.Name = "sizeBar";
            this.sizeBar.Size = new System.Drawing.Size(300, 1000);
            this.sizeBar.TabIndex = 0;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.menuPanel.Controls.Add(this.iconButton);
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(70, 1000);
            this.menuPanel.TabIndex = 1;
            // 
            // iconButton
            // 
            this.iconButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.iconButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.iconButton.BackgroundImage = global::trelloclone.Properties.Resources.icon;
            this.iconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.iconButton.BorderRadius = 0;
            this.iconButton.BorderSize = 0;
            this.iconButton.FlatAppearance.BorderSize = 0;
            this.iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton.ForeColor = System.Drawing.Color.White;
            this.iconButton.Location = new System.Drawing.Point(0, 0);
            this.iconButton.Name = "iconButton";
            this.iconButton.Size = new System.Drawing.Size(70, 70);
            this.iconButton.TabIndex = 0;
            this.iconButton.TextColor = System.Drawing.Color.White;
            this.iconButton.UseVisualStyleBackColor = false;
            // 
            // myTablePanel
            // 
            this.myTablePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(85)))), ((int)(((byte)(186)))));
            this.myTablePanel.Controls.Add(this.myTableButton);
            this.myTablePanel.Location = new System.Drawing.Point(70, 0);
            this.myTablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.myTablePanel.Name = "myTablePanel";
            this.myTablePanel.Size = new System.Drawing.Size(230, 800);
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
            this.myTableButton.Location = new System.Drawing.Point(0, 0);
            this.myTableButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myTableButton.Name = "myTableButton";
            this.myTableButton.Size = new System.Drawing.Size(215, 50);
            this.myTableButton.TabIndex = 0;
            this.myTableButton.Text = "Các bảng của bạn\r\n";
            this.myTableButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myTableButton.TextColor = System.Drawing.Color.White;
            this.myTableButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 681);
            this.Controls.Add(this.sizeBar);
            this.Controls.Add(this.WorkSpacePanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.sizeBar.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.myTablePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel WorkSpacePanel;
        private RJButton myTableButton;
        private System.Windows.Forms.Timer timerMyTable;
        private FlowLayoutPanel sizeBar;
        private Panel menuPanel;
        private Panel myTablePanel;
        private RJButton iconButton;
    }
}
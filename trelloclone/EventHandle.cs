using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ui;

namespace trelloclone
{
    public class EventHandlers
    {
        private Form1 mainForm;

        //WorkSpace
        private Panel workSpace;
        //TableSpace
        private Panel tableSpace;
        private List<RJButton> buttons;
        private List<RJButton> otpBtn;
        private RJButton myTableButton;
        private Panel textBoxPanel;
        private string textBoxContent = "";
        //MenuSpace
        private Timer sideBarTimer;
        private FlowLayoutPanel sideBar;
        private RJButton iconButton;
        bool sidebarExpand = true;

        public Panel WorkSpace { get => workSpace; set => workSpace = value; }
        public RJButton MyTableButton { get => myTableButton; set => myTableButton = value; }
        public List<RJButton> Buttons { get => buttons; set => buttons = value; }
        public Panel TableSpace { get => tableSpace; set => tableSpace = value; }
        public List<RJButton> OtpBtn { get => otpBtn; set => otpBtn = value; }

        public EventHandlers(Form1 form, Panel WorkSpace, Panel TableSpace, RJButton myTableButton, Timer timer, FlowLayoutPanel sideBar, RJButton iconButton)
        {
            this.mainForm = form;
            //WorkSpace
            this.workSpace = WorkSpace;
            //TableSpace
            this.tableSpace = TableSpace;
            this.myTableButton = myTableButton;
            this.myTableButton.Click += myTableButton_Click;
            Buttons = new List<RJButton>();
            OtpBtn = new List<RJButton>();
            //MenuSpace
            this.sideBarTimer = timer;
            this.sideBarTimer.Interval = 1;
            this.sideBarTimer.Tick += Timer_Tick;
            this.sideBar = sideBar;
            this.iconButton = iconButton;
            this.iconButton.Click += IconButton_Click;
        }

        private void IconButton_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //Set the Minimum and maxim
            if(sidebarExpand)
            {
                //if sidebar is expand, minimize
                sideBar.Width -= 10;
                if(sideBar.Width == sideBar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sideBarTimer.Stop();
                }    
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sideBarTimer.Stop();
                }
            }    
        }

        public void myTableButton_Click(object sender, EventArgs e)
        {
            RJButton btn = sender as RJButton;
            CreateTextBox(btn);
        }

        private void CreateTextBox(RJButton btn)
        {
            if (textBoxPanel != null)
            {
                WorkSpace.Controls.Remove(textBoxPanel);
                textBoxContent = "";
            }
            textBoxPanel = new Panel()
            {
                Width = Const.panelTextBoxWidth,
                Height = Const.panelTextBoxHeight,
                Location = new Point(Const.myTableWidth, 0),
                BackgroundImage = Image.FromFile(Application.StartupPath + "/Resources/myTablePanel.png"),
                BackgroundImageLayout = ImageLayout.Stretch,
                BackColor = Color.Transparent
            };
            WorkSpace.Controls.Add(textBoxPanel);
            textBoxPanel.BringToFront();

            Label headLabel = new Label()
            {
                Text = "Tạo Bảng",
                Width = Const.panelTextBoxWidth,
                Location = new Point(0, 25),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            };

            Label titleLabel = new Label()
            {
                Text = "Tiêu đề bảng",
                Width = Const.panelTextBoxWidth,
                Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new Point(25, textBoxPanel.Location.Y + 75),
            };

            TextBox text = new TextBox()
            {
                Width = Const.panelTextBoxWidth - 50,
                Location = new Point(25, textBoxPanel.Location.Y + 100),
            };
            text.TextChanged += Text_TextChanged;

            Label noteLineLabel = new Label()
            {
                Text = "Tiêu đề bảng là bắt buộc",
                Width = Const.panelTextBoxWidth,
                Location = new Point(25, text.Location.Y + text.Height + 10),
            };

            RJButton newBtn = new RJButton()
            {
                Width = Const.panelTextBoxWidth - 50,
                Height = 50,
                BackColor = Color.Gray,
                Location = new Point(25, textBoxPanel.Location.Y + (textBoxPanel.Height/3)*2),
                Text = "Tạo Bảng Mới",
                Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            };
            newBtn.Click += CreateTable_Click;

            RJButton exitButton = new RJButton()
            {
                Width = Const.exitBtnWidth,
                Height = Const.exitBtnWidth,
                Location = new Point(textBoxPanel.Width - Const.exitBtnWidth - 15, 15),
                BackgroundColor = Color.Transparent,
                BorderRadius = 10,
                BackgroundImage = Image.FromFile(Application.StartupPath + "/Resources/close.png"),
                BackgroundImageLayout = ImageLayout.Stretch,
            };
            exitButton.Click += ExitButton_Click;
            textBoxPanel.Controls.Add(headLabel);
            textBoxPanel.Controls.Add(titleLabel);
            textBoxPanel.Controls.Add(text);
            textBoxPanel.Controls.Add(noteLineLabel);
            textBoxPanel.Controls.Add(newBtn);
            textBoxPanel.Controls.Add(exitButton);
            exitButton.BringToFront();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            WorkSpace.Controls.Remove(textBoxPanel);
            textBoxContent = "";
        }

        private void Text_TextChanged(object sender, EventArgs e)
        {
            // Lưu nội dung của TextBox vào biến
            textBoxContent = ((TextBox)sender).Text;
        }

        private void CreateTable_Click(object sender, EventArgs e)
        {
            if (textBoxContent == "")
            {
                MessageBox.Show("Tiêu đề không được để trống");
            }
            else
            {
                RJButton newButton = new RJButton()
                {
                    Width = myTableButton.Width,
                    Height = myTableButton.Height,
                    BorderRadius = 0,
                    BorderSize = 0,
                    BackColor = Color.Transparent,
                    Text = textBoxContent,
                    Font = new Font("Microsoft Sans Serif", 10,FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Tag = Buttons.Count
                };
                if (Buttons.Count == 0)
                {
                    newButton.Location = new Point(myTableButton.Location.X, myTableButton.Location.Y + myTableButton.Height);
                }
                else
                {
                    int lastIndex = Buttons.Count - 1;
                    newButton.Location = new Point(Buttons[lastIndex].Location.X, Buttons[lastIndex].Location.Y + Buttons[lastIndex].Height);
                }
                TableSpace.Controls.Add(newButton);
                RJButton optBtn = new RJButton()
                {
                    Width = 25,
                    Height = 20,
                    BorderRadius = 10,
                    BorderSize = 0,
                    Location = new Point(newButton.Location.X + newButton.Width - 30, newButton.Location.Y + 10),
                    BackColor= Color.Transparent,
                    BackgroundImage = Image.FromFile(Application.StartupPath + "/Resources/....png"),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Tag = newButton.Tag
                };
                optBtn.Click += OptBtn_Click;
                TableSpace.Controls.Add(optBtn);
                optBtn.BringToFront();
                WorkSpace.Controls.Remove(textBoxPanel);
                textBoxContent = "";
                Buttons.Add(newButton); //Nhet button Table vua tao vao trong mang de quan ly
                OtpBtn.Add(optBtn);
            }
        }

        private void OptBtn_Click(object sender, EventArgs e)
        {
            RJButton btn = (RJButton)sender;
            Guna2GradientButton deleteTableButton = new Guna2GradientButton()
            {
                Text = "Delete Table",
                Location = new Point(btn.Location.X, btn.Location.Y + btn.Height + 55),
                BorderRadius = 10,
                BackColor = Color.Transparent,
                Tag = btn.Tag,
            };
            mainForm.Controls.Add(deleteTableButton);
            deleteTableButton.BringToFront();
            deleteTableButton.Click += DeleteTableButton_Click;
        }

        private void Update_Location_After_Remove(int index)
        {
            if (index == Buttons.Count - 1)
            {
                Buttons.RemoveAt(Convert.ToInt32(index));
                OtpBtn.RemoveAt(Convert.ToInt32(index));
            }    
            else 
            {
                for (int i = Buttons.Count - 1; i > index; i--)
                {
                    Buttons[i].Location = Buttons[i - 1].Location;
                    Buttons[i].Tag = Buttons[i - 1].Tag;
                    OtpBtn[i].Location = OtpBtn[i - 1].Location;
                    OtpBtn[i].Tag = OtpBtn[i - 1].Tag;
                }
                Buttons.RemoveAt(Convert.ToInt32(index));
                OtpBtn.RemoveAt(Convert.ToInt32(index));
            }
        }

        private void DeleteTableButton_Click(object sender, EventArgs e)
        {
            Guna2GradientButton btn = (Guna2GradientButton)sender;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bảng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                TableSpace.Controls.Remove(Buttons[Convert.ToInt32(btn.Tag)]);
                TableSpace.Controls.Remove(OtpBtn[Convert.ToInt32(btn.Tag)]);
                Update_Location_After_Remove(Convert.ToInt32(btn.Tag));
            }
            mainForm.Controls.Remove(btn);
        }
    }
}

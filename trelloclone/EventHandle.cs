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
        private Form1 form;
        private Panel workSpace;
        private Panel tableSpace;
        private List<RJButton> buttons;
        private RJButton myTableButton;
        private Panel textBoxPanel;
        private string textBoxContent = "";

        public Panel WorkSpace { get => workSpace; set => workSpace = value; }
        public RJButton MyTableButton { get => myTableButton; set => myTableButton = value; }
        public List<RJButton> Buttons { get => buttons; set => buttons = value; }
        public Panel TableSpace { get => tableSpace; set => tableSpace = value; }

        public EventHandlers(Panel WorkSpace, Panel TableSpace, RJButton myTableButton)
        {
            this.form = form;
            this.workSpace = WorkSpace;
            this.tableSpace = TableSpace;
            this.myTableButton = myTableButton;
            this.myTableButton.Click += myTableButton_Click;
            buttons = new List<RJButton>();
        }

        public void myTableButton_Click(object sender, EventArgs e)
        {
            RJButton btn = sender as RJButton;
            CreateTextBox(btn);
        }

        private void CreateTextBox(RJButton btn)
        {
            textBoxPanel = new Panel()
            {
                Width = Const.panelTextBoxWidth,
                Height = Const.panelTextBoxHeight,
                Location = new Point(0, 0),
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

            RJButton newBtn = new RJButton()
            {
                Width = Const.panelTextBoxWidth - 50,
                Height = 50,
                BackColor = Color.Gray,
                Location = new Point(25, textBoxPanel.Location.Y + (textBoxPanel.Height/3)*2),
                Text = "Tạo Bảng Mới",
                Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            };
            newBtn.Click += NewBtn_Click;
            textBoxPanel.Controls.Add(headLabel);
            textBoxPanel.Controls.Add(titleLabel);
            textBoxPanel.Controls.Add(text);
            textBoxPanel.Controls.Add(newBtn);
        }

        private void Text_TextChanged(object sender, EventArgs e)
        {
            // Lưu nội dung của TextBox vào biến
            textBoxContent = ((TextBox)sender).Text;
        }

        private void NewBtn_Click(object sender, EventArgs e)
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
                    TextAlign = ContentAlignment.MiddleLeft
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
                Buttons.Add(newButton);
                TableSpace.Controls.Add(newButton);
                WorkSpace.Controls.Remove(textBoxPanel);
            }
        }
    }
}

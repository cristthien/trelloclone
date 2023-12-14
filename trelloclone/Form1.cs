using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trelloclone
{
    public partial class Form1 : Form
    {
        EventHandlers eventHandlers;

        public EventHandlers EventHandlers { get => eventHandlers; set => eventHandlers = value; }
        public Form1()
        {
            InitializeComponent();
            sizeBar.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            EventHandlers = new EventHandlers(this, WorkSpacePanel, myTablePanel, myTableButton, timerMyTable, sizeBar, iconButton);
        }
    }
}

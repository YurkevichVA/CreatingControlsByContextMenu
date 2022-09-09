using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingControlsByContextMenu
{
    public partial class Form1 : Form
    {
        List<ToolStripMenuItem> listToolStripMenuItem = new List<ToolStripMenuItem>();
        private int buttonsCount = 0;
        private int textBoxesCount = 0;
        private int checkBoxesCount = 0;
        private int newControlX;
        private int newControlY;
        public Form1()
        {
            InitializeComponent();
        }
        private void AddControl(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            Control newControl;
            if (item.Name == "ButtonCreate")
            {
                newControl = new Button();
                buttonsCount++;
                if (buttonsCount == 3)
                    contextMenu.Items.RemoveByKey("ButtonCreate");
                else
                    contextMenu.Items[contextMenu.Items.IndexOfKey("ButtonCreate")].Text = $"Створити кнопку ({3 - buttonsCount})";
            }
            else if (item.Name == "TextBoxCreate")
            {
                newControl = new TextBox();
                textBoxesCount++;
                if (textBoxesCount == 3)
                    contextMenu.Items.RemoveByKey("TextBoxCreate");
                else
                    contextMenu.Items[contextMenu.Items.IndexOfKey("TextBoxCreate")].Text = $"Створити текстове поле ({3 - textBoxesCount})";
            }
            else
            {
                newControl = new CheckBox();
                checkBoxesCount++;
                if (checkBoxesCount == 3)
                    contextMenu.Items.RemoveByKey("CheckBoxCreate");
                else
                    contextMenu.Items[contextMenu.Items.IndexOfKey("CheckBoxCreate")].Text = $"Створити чекбокс ({3 - checkBoxesCount})";
            }

            newControl.Location = new Point(newControlX, newControlY);
            newControl.Visible = true;
            Controls.Add(newControl);
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenu.Show();
        }

        private void contextMenu_Opened(object sender, EventArgs e)
        {
            newControlX = contextMenu.Bounds.X;
            newControlY = contextMenu.Bounds.Y;
        }
    }
}

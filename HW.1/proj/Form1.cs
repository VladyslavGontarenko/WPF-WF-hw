using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj
{
    public partial class Form1 : Form
    {
        int count = 1;

        public Form1()
        {
            InitializeComponent();

            ToolStripMenuItem fileItem = new ToolStripMenuItem(Convert.ToString(count));
            count++;

            fileItem.MouseEnter += Select;

            menuStrip1.Items.Add(fileItem);
        }

        void Select(object sender, EventArgs e)
        {
            ToolStripMenuItem fileItem = sender as ToolStripMenuItem;

            fileItem.DropDownItems.Add(Convert.ToString(count)).MouseEnter += Select;
            
            count++;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Calculator
{
    class MyForm : Form
    {
        public MyForm()
        {
            TableLayoutPanel table = new TableLayoutPanel
            {
                ColumnCount = 4,
                RowCount = 8,
                BackColor = Color.Beige,
                Dock = DockStyle.Fill
            };
            Controls.Add(table);
            
        }
    }
}

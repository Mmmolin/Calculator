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
                RowCount = 6,
                BackColor = Color.Beige,
                Dock = DockStyle.Fill
            };
            Controls.Add(table);
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));

            TextBox mainIO = new TextBox
            {
                Dock = DockStyle.Fill
            };
            table.Controls.Add(mainIO);
            table.SetColumnSpan(mainIO, 4);
            table.SetRowSpan(mainIO, 2);           
        }


    }
}

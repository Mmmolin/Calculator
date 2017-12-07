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
            MinimumSize = new Size(330, 360);
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

            table.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 20));

            TextBox mainIO = new TextBox
            {
                Dock = DockStyle.Fill,
                Font = new Font("serif", 24),
                RightToLeft = RightToLeft.Yes
            };
            table.Controls.Add(mainIO);
            table.SetColumnSpan(mainIO, 4);

            Button ce = new Button
            {
                Text = "CE",
                Dock = DockStyle.Fill
            };
            table.Controls.Add(ce);
            Button c = new Button
            {
                Text = "C",
                Dock = DockStyle.Fill
            };
            table.Controls.Add(c);
            Button back = new Button
            {
                Text = "<=",
                Dock = DockStyle.Fill
            };
            table.Controls.Add(back);
            Button divide = new Button
            {
                Text = "/",
                Dock = DockStyle.Fill
            };
            table.Controls.Add(divide);





        }
    }
}

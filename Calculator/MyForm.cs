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

            table.Controls.Add(ButtonMaker("CE"));
            table.Controls.Add(ButtonMaker("C"));
            table.Controls.Add(ButtonMaker("<="));
            table.Controls.Add(ButtonMaker("/"));

            table.Controls.Add(ButtonMaker("7"));
            table.Controls.Add(ButtonMaker("8"));
            table.Controls.Add(ButtonMaker("9"));
            table.Controls.Add(ButtonMaker("X"));

            table.Controls.Add(ButtonMaker("4"));
            table.Controls.Add(ButtonMaker("5"));
            table.Controls.Add(ButtonMaker("6"));
            table.Controls.Add(ButtonMaker("-"));

            table.Controls.Add(ButtonMaker("1"));
            table.Controls.Add(ButtonMaker("2"));
            table.Controls.Add(ButtonMaker("3"));
            table.Controls.Add(ButtonMaker("+"));

            table.Controls.Add(ButtonMaker("∓"));
            table.Controls.Add(ButtonMaker("0"));
            table.Controls.Add(ButtonMaker(","));
            table.Controls.Add(ButtonMaker("="));

        }
        public Button ButtonMaker(string text)
        {
            Button button = new Button
            {
                Text = text,
                Dock = DockStyle.Fill
            };
            return button;
        }
    }
}

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
        public static NumericUpDown mainIO;

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

            mainIO = new NumericUpDown
            {
                Dock = DockStyle.Fill,
                Font = new Font("serif", 24),
                RightToLeft = RightToLeft.Yes,
                Maximum = 10000000000,
                Minimum = -1000
            };
            mainIO.Controls[0].Visible = false;
            table.Controls.Add(mainIO);
            table.SetColumnSpan(mainIO, 4);

            string[] buttonText = { "CE", "C", "<=", "/", "7", "8", "9", "X", "4", "5", "6", "-", "1", "2", "3", "+", "∓", "0", ",", "=" };
            foreach (string text in buttonText)
            {
                table.Controls.Add(ButtonMaker(text));
                table.Controls[table.Controls.Count - 1].Click += ClickedKeyEventHandler;
            }
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

        public void ClickedKeyEventHandler(object sender, EventArgs e)
        {
            Button recieved = (Button)sender;
            string keyPressed = recieved.Text.ToString();
            switch (keyPressed)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "0":
                    mainIO.Text += keyPressed;
                    break;
                case "C":
                    mainIO.ResetText();
                    Calculate.NumbersAndOperators.Clear();
                    break;
                case "+":
                case "-":
                case "/":
                case "X":
                    Calculate.NumbersAndOperators.Add(mainIO.Text);
                    Calculate.NumbersAndOperators.Add(keyPressed);
                    mainIO.ResetText();
                    break;
                case "=":
                    Calculate.NumbersAndOperators.Add(mainIO.Text);
                    mainIO.ResetText();
                    mainIO.Text = Calculate.CalculateResult().ToString();
                    break;
            }
        }
    }
}

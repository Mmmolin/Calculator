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
        TextBox mainIO;
        List<object> NumbersAndOperators = new List<object> { };
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

            mainIO = new TextBox
            {
                Dock = DockStyle.Fill,
                Font = new Font("serif", 24),
                RightToLeft = RightToLeft.Yes
            };
            table.Controls.Add(mainIO);
            table.SetColumnSpan(mainIO, 4);

            string[] buttonText = { "CE", "C", "<=", "/", "7", "8", "9", "X", "4", "5", "6", "-", "1", "2", "3", "+", "∓", "0", ",", "=" };
            foreach (string text in buttonText)
            {
                table.Controls.Add(ButtonMaker(text));
                table.Controls[table.Controls.Count - 1].Click += ClickedKeyEventHandler;
                //GetControl(text).Click += ClickedKeyEventHandler;
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
        public Control GetControl(string text)
        {
            Control returnThis = null;
            foreach (Control control in Controls)
            {
                if (control.Text == text)
                {
                    returnThis = control;
                }
            }
            return returnThis;
        }
        public void ClickedKeyEventHandler(object sender, EventArgs e)
        {
            Button recieved = (Button)sender;
            string keyPressed = recieved.Text.ToString();
            switch(keyPressed)
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
                    mainIO.Clear();
                    break;
                case "+":
                case "-":
                case "/":
                case "X":                    
                    break;
            }
        }
    }
}

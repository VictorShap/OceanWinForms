using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OceanWinForms.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.ColumnCount = 70;
            tableLayoutPanel1.ColumnCount = 30;
            Label lbl = new Label();
            lbl.Text = "0";
            tableLayoutPanel1.Controls.Add(lbl, 0, 0);
            Label lbl1 = new Label();
            lbl1.Text = "1";
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.Controls.Add(lbl1, 1, 1);
        }
    }
}
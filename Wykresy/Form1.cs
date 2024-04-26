using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Wykresy
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            buttonAddFunction_Click(null, null);
        }

        private void buttonAddFunction_Click(object sender, EventArgs e)
        {
            UserControlFunction ucf = new UserControlFunction(++i);

            Series s = new Series();
            chart1.Series.Add(s);
            s.Tag = ucf;

            ucf.FunctionChanged += RefreshChart;
            ucf.FunctionDeleted += Ucf_FunctionDeleted;

            flowLayoutPanel1.Controls.Add(ucf);

            RefreshChart(ucf);
        }

        private void Ucf_FunctionDeleted(object sender)
        {
            if (sender is UserControlFunction)
            {
                flowLayoutPanel1.Controls.Remove(sender as UserControlFunction);
                chart1.Series.Remove(chart1.Series.Single(s => s.Tag == sender));
            }
        }

        private void RefreshChart(object sender)
        {
            foreach (Series s in chart1.Series)
            {
                if (s.Tag == sender)
                {
                    if (sender is UserControlFunction)
                    {
                        UserControlFunction ucf = (sender as UserControlFunction);

                        s.Points.Clear();
                        for (decimal x = -10; x <= 10; x += 1)
                        {
                            s.Points.AddXY(x, ucf.GetY(x));
                        }
                        s.Name = ucf.FunctionText;
                    }
                }
            }
            chart1.ChartAreas.First().RecalculateAxesScale();
        }
    }
}

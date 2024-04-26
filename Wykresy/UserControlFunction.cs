using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wykresy
{
    public partial class UserControlFunction : UserControl
    {
        private int i;
        public string FunctionText
        {
            get { return groupBoxFunction.Text; }
        }

        public delegate void ActionWithSender(object sender);
        public event ActionWithSender FunctionDeleted;
        public event ActionWithSender FunctionChanged;
        public UserControlFunction(int i)
        {
            this.i = i;
            InitializeComponent();
            NumericUpDown_ValueChanged(null, null);
        }

        public decimal GetY(decimal x)
        {
            return numericUpDownA.Value * x * x + numericUpDownB.Value * x + numericUpDownC.Value;
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            groupBoxFunction.Text = $"f{i}(x) = {numericUpDownA.Value} x² + {numericUpDownB.Value} x + {numericUpDownC.Value}";
            //FunctionChanged?.Invoke();
            if (FunctionChanged != null)
            {
                FunctionChanged(this);
            }
        }

        private void labelTrash_Click(object sender, EventArgs e)
        {
            if (FunctionDeleted != null)
            {
                FunctionDeleted(this);
            }
        }
    }
}

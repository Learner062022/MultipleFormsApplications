using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DylanDeSouzaWk12ExAMultipleForms
{
    public partial class frmLargeCar : Form
    {
        public static int LARGE_CAR_DAILY_RATE = 40;

        public frmLargeCar()
        {
            InitializeComponent();
            toolTip1.SetToolTip(txt_hire_charge, "Enter a number");
            toolTip1.SetToolTip(txt_num_days_hired, "Enter a number");
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            int int_num_days = 0;
            int int_num_charge = 0;

            try
            {
                int_num_days = int.Parse(txt_num_days_hired.Text);
                int_num_charge = int_num_days * LARGE_CAR_DAILY_RATE;
                txt_hire_charge.Text = int_num_charge.ToString("C");
                errorProvider1.Dispose();
            }
            catch
            {
                errorProvider1.SetError(txt_num_days_hired, txt_num_days_hired.Text + "isn't a number - Enter another number");
            }
            finally
            {
                txt_num_days_hired.Clear();
                txt_num_days_hired.Focus();
            }
        }
    }
}

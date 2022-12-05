using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DylanDeSouzaWk12ExAMultipleForms
{
    public partial class frmMediumCar : Form
    {

        public static int MEDIUM_CAR_DAILY_RATE = 30;

        public frmMediumCar()
        {
            InitializeComponent();
            toolTip1.SetToolTip(txt_hire_charge, "Enter a number");
            toolTip1.SetToolTip(txt_num_days_hired, "Enter a number");
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            int int_num_days = 0;
            int int_num_charge = 0;
            bool were_errors = false;

            try
            {
                int_num_days = int.Parse(txt_num_days_hired.Text);
                int_num_charge = int_num_days * MEDIUM_CAR_DAILY_RATE;
                txt_hire_charge.Text = int_num_charge.ToString("C");
                were_errors = false;
                errorProvider1.Dispose();
            }
            catch
            {
                errorProvider1.SetError(txt_num_days_hired, txt_num_days_hired.Text + " isn't a number - Enter another number");
                were_errors = true;
            }
            finally
            {
                txt_num_days_hired.Clear();
                txt_num_days_hired.Focus();
            }
        }
    }
}

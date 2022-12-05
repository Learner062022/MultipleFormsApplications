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
using TextBox = System.Windows.Forms.TextBox;

namespace DylanDeSouzaWk12ExAMultipleForms
{
    public partial class frmCarRentals : Form
    {
        public frmCarRentals()
        {
            InitializeComponent();
            lst_car_type_daily_fee.Items.Add("Car Type\tDaily Rate");
            lst_car_type_daily_fee.Items.Add("Small\t" + frmSmallCar.SMALL_CAR_DAILY_RATE.ToString("C"));
            lst_car_type_daily_fee.Items.Add("Medium\t" + frmMediumCar.MEDIUM_CAR_DAILY_RATE.ToString("C"));
            lst_car_type_daily_fee.Items.Add("Medium\t" + frmLargeCar.LARGE_CAR_DAILY_RATE.ToString("C"));
        }

        private void btn_small_Click(object sender, EventArgs e)
        {
            frmSmallCar frm_small_car = new frmSmallCar();
            frm_small_car.ShowDialog();
        }

        private void btn_medium_Click(object sender, EventArgs e)
        {
            frmMediumCar frm_medium_car = new frmMediumCar();
            frm_medium_car.ShowDialog();
        }

        private void btn_large_Click(object sender, EventArgs e)
        {
            frmLargeCar frm_large_car = new frmLargeCar();
            frm_large_car.ShowDialog();
        }
    }
}

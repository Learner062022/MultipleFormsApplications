using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DylanDeSouzaWk12ExAMultipleForms
{
    public partial class frmNameAcceptance : Form
    {
        public static string str_given_name;
        public frmNameAcceptance()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            frmNames frm_my_display = new frmNames();
            frm_my_display.ShowDialog();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string str_first_name, str_surname;

            str_first_name = txtFirstName.Text;
            str_surname = txtLastName.Text;

            str_given_name = str_first_name + "\t" + str_surname;
            txtFirstName.Clear();
            txtLastName.Clear();
            txtFirstName.Focus();
        }
    }
}

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
    public partial class frmNames : Form
    {
        public frmNames()
        {
            InitializeComponent();
            lstNames.Items.Add("First Name\tLast Name");
            lstNames.Items.Add(frmNameAcceptance.str_given_name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_BenhVien.Forms
{
    public partial class Form_SignUp : Form
    {

        public Form_SignUp()
        {
            InitializeComponent();
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = (BackColor);
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

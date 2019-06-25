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


        #region Effect
        private void btnSignUp_Enter(object sender, EventArgs e)
        {
            btnSignUp.BackColor = Color.Green;
            btnSignUp.ForeColor = Color.White;
        }

        private void btnSignUp_Leave(object sender, EventArgs e)
        {
            btnSignUp.BackColor = Color.White;
            btnSignUp.ForeColor = Color.Green;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (true)
            {
                //ptbMessage = @"Images\icons8-checkmark-filled-50";
            }
        }
    }
        #endregion
}


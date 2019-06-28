using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_BenhVien.UserControls;

namespace UI_BenhVien.Forms
{
    public partial class Form_Menu : Form
    {
        //public bool admin = false;
        public Form_Menu()
        {
            InitializeComponent();
            lblHello.Text = Form_Login.DisplayName;
            ucAdmin.cbObject.Visible = false;
            btnAdmin.Enabled = Form_Login.admin;

        }
        private static Form_Menu instance;
        public static Form_Menu Instance
        {
            get
            {
                if (instance == null) instance = new Form_Menu(); return instance;
            }
            set
            {
                instance = value;
            }
        }

        

        private void btnAction_Click(object sender, EventArgs e)
        {
            UC_Action.Tb = 1;
            #region effect

            btnAction.BackColor = Color.SeaGreen;
            btnAction.ForeColor = Color.White;
            //
            btnAdmin.BackColor = Color.PaleGreen;
            btnAdmin.ForeColor = Color.Gray;
            //
            btnAuthor.BackColor = Color.PaleGreen;
            btnAuthor.ForeColor = Color.Gray;
            // Hide and show User Controls
            if (ucAdmin.Visible == true)
                transition2.HideSync(ucAdmin);
            else if (ucAuthor.Visible == true)
                transition2.HideSync(ucAuthor);
            transition.ShowSync(ucAction);
            #endregion
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            UC_Action.Tb = 2;
            #region effect
            
            btnAdmin.BackColor = Color.SeaGreen;
            btnAdmin.ForeColor = Color.White;
            //
            btnAuthor.BackColor = Color.PaleGreen;
            btnAuthor.ForeColor = Color.Gray;
            //
            btnAction.BackColor = Color.PaleGreen;
            btnAction.ForeColor = Color.Gray;
            // hide and show User Controls
            if (ucAction.Visible == true)
                transition2.HideSync(ucAction);
            else if (ucAuthor.Visible == true)
                transition2.HideSync(ucAuthor);
            transition.ShowSync(ucAdmin);

            #endregion
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            
            #region effect
            
            btnAuthor.BackColor = Color.SeaGreen;
            btnAuthor.ForeColor = Color.White;
            //
            btnAction.BackColor = Color.PaleGreen;
            btnAction.ForeColor = Color.Gray;
            //
            btnAdmin.BackColor = Color.PaleGreen;
            btnAdmin.ForeColor = Color.Gray;
            //
            // Hide and show User Controls
            if (ucAction.Visible == true)
                transition2.HideSync(ucAction);
            else if (ucAdmin.Visible == true)
                transition2.HideSync(ucAdmin);
            transition.ShowSync(ucAuthor);

            #endregion
        }

        private void btnExit_Click(object sender, EventArgs e)  // minimize the form
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e) // close the form
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #region Effect Events

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Red;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.LimeGreen;
        }
        #endregion

    }
}

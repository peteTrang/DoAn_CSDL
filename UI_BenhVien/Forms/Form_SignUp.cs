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
            bool b = false;
            //code
            using (QuanLyBenhVienDataContext db = new QuanLyBenhVienDataContext())
            {
                if(txbUsername.Text == String.Empty)
                {
                    MessageBox.Show("Không được để trống mục username", "Thông báo");
                }
                if(txbPassword.Text == String.Empty)
                {
                    MessageBox.Show("Không được để trống mục password", "Thông báo");
                }
                if(txbUsername.Text != String.Empty && txbPassword.Text != String.Empty)
                {
                    var a = from acc in db.accounts
                            where acc.usernamme == txbUsername.Text
                            select acc;
                    if (a.Count() > 0)
                    {
                        MessageBox.Show("Username đã được sử dụng. Xin nhập một username khác", "Thông báo");
                    }
                    else
                    {
                        account newAcc = new account();
                        newAcc.usernamme = txbUsername.Text;
                        newAcc.password = txbPassword.Text;
                        newAcc.tenhienthi = txbUsername.Text;
                        newAcc.admin = false;
                        db.accounts.InsertOnSubmit(newAcc);
                        db.SubmitChanges();
                        b = true;
                    }
                }
            }
            // effect
            // condition to be succeed or fail
            if (b)
            {
                ptbMessage.Image = global::UI_BenhVien.Properties.Resources.icons8_checkmark_filled_50;
                txbMessage.Text = "Thành công!";
                txbMessage.ForeColor = Color.Green;
            }
            else
            {
                ptbMessage.Image = global::UI_BenhVien.Properties.Resources.icons8_no_50;
                txbMessage.Text = "Không thành công!";
                txbMessage.ForeColor = Color.Red;
            }
            pnlMessage.Visible = true;
        }
    }
        #endregion
}


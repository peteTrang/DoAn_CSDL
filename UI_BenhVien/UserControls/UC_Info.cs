using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_BenhVien.Forms;

namespace UI_BenhVien.UserControls
{
    public partial class UC_Info : UserControl
    {
        private static int _dem1;
        public bool delete;


        public UC_Info()
        {
            InitializeComponent();
             delete = false;

        }

        public static int Dem1
        {
            get
            {
                return _dem1;
            }

            set
            {
                _dem1 = value;
            }
        }

        public void btnDelete_Click(object sender, EventArgs e)
        {
            delete = true;
            Dem1 = Dem1 - 1;
            UC_Action hao = (UC_Action)this.Parent.Parent;
            using (QuanLyBenhVienDataContext db = new QuanLyBenhVienDataContext())
            {
                var a = (from bnhan in db.BenhNhans
                        where bnhan.MaBN.ToString() == this.txbID.Text
                        select bnhan).FirstOrDefault();
                db.BenhNhans.DeleteOnSubmit(a);
                db.SubmitChanges();
            }
            hao.DisplayResult(Dem1);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txbID.ReadOnly = txbName.ReadOnly = textBox1.ReadOnly = textBox2.ReadOnly = false;
            btnSave.Visible = true;
            btnEdit.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txbID.ReadOnly = txbName.ReadOnly = textBox1.ReadOnly = textBox2.ReadOnly = false;
            btnEdit.Visible = true;
            btnSave.Visible = false;
        }
    }
}

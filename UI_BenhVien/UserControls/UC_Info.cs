﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_BenhVien.Forms;
using System.Data.Linq.SqlClient;

namespace UI_BenhVien.UserControls
{
    public partial class UC_Info : UserControl
    {
        private static int _dem1;
        private static int cbindex;
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

        public static int Cbindex
        {
            get
            {
                return cbindex;
            }

            set
            {
                cbindex = value;
            }
        }

        public void btnDelete_Click(object sender, EventArgs e)
        {
            delete = true;
            //UC_Action.Instace.pnlShow = new Panel();
            Dem1 = Dem1 - 1;
            //int c = UC_Action.ucInfos.Count;
            UC_Action hao = (UC_Action)this.Parent.Parent;
            //var a = this.Parent.Parent;
            using (QuanLyBenhVienDataContext db = new QuanLyBenhVienDataContext())
            {
                if (cbindex == 1)
                {
                    var a = (from bnhan in db.BenhNhans
                             where bnhan.MaBN.ToString() == this.txbID.Text
                             select bnhan).FirstOrDefault();
                    db.BenhNhans.DeleteOnSubmit(a);
                    db.SubmitChanges();
                }
                else
                {
                    var a = (from bsy in db.NhanViens
                             where bsy.MaNV.ToString() == this.txbID.Text
                             select bsy).FirstOrDefault();
                    db.NhanViens.DeleteOnSubmit(a);
                    db.SubmitChanges();
                }
            }
            hao.DisplayResult(Dem1);
            //UC_Action.Instace.pnlShow.Refresh();
            //txbID           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form_Add : Form
    {
        Panel pnlPlaceHolder = new Panel();  
        public Form_Add()
        {
            InitializeComponent();
            cbObject.SelectedItem = "Bệnh nhân";
            pnlPlaceHolder.Location = panel2.Location;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbObject.SelectedIndex == 0) // Add a patient
            {
                pnlChuyenNganh.Visible = false;
                pnlSex.Visible = true;
                pnlAddress.Visible = true;
                using (QuanLyBenhVienDataContext db = new QuanLyBenhVienDataContext())
                {
                    var Benh = from benh in db.BenhLies
                               select benh.TenBenh;
                    comboBox2.Items.Clear();
                    foreach (var a in Benh)
                    {
                        comboBox2.Items.Add(a);
                    }
                }
                label1.Text = "Ngày sinh:";
                lblAddress.Text = "Địa chỉ:";
                label2.Text = "Bệnh:";

                panel2.Location = new Point(12, 190);
            }
            else if (cbObject.SelectedIndex == 1)    // Add an employee
            {
                pnlChuyenNganh.Visible = true;
                pnlSex.Visible = false;
                pnlAddress.Visible = false;
                using (QuanLyBenhVienDataContext db = new QuanLyBenhVienDataContext())
                {
                    var TenKhoa = from ten in db.Khoas
                                  select ten.TenKhoa;

                    var TenChuyenNganh = from ten in db.ChuyenNganhs
                                         select ten.TenChuyenNganh;

                    comboBox2.Items.Clear();
                    cbChuyenNganh.Items.Clear();
                    foreach (var a in TenKhoa)
                    {
                        comboBox2.Items.Add(a);
                    }

                    foreach (var a in TenChuyenNganh)
                    {
                        cbChuyenNganh.Items.Add(a);
                    }
                }
                label1.Text = "Chức danh:";
                label2.Text = "Khoa:";

                pnlChuyenNganh.Location = panel2.Location;
                panel2.Location = pnlAddress.Location;

                textBox1.Name = "txbChucDanh";

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          /*
           * Bệnh nhân:
           *        textBox1 = ngày sinh
           *        txbAddress =  địa chỉ
           *        combobox2 = bệnh
           *        
           * Nhân viên:
           *        combobox2 = tên khoa
           *        txbChuyenNganh =  chuyên ngành
           */
        }
    }
}

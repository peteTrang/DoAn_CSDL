using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq.SqlClient;
namespace UI_BenhVien.UserControls
{
    public partial class UC_Action : UserControl
    {
        int a = 24;
        private static UC_Action _instace;
        private int dem;
        private static int tb;
        public static UC_Action Instace {
            get
            {
                if (_instace == null)
                _instace = new UC_Action(); return _instace;
            }
            set { _instace = value; }
        }

        public int Dem { get => dem; set => dem = value; }
        public static int Tb { get => tb; set => tb = value; }

        public static List<UC_Info> ucInfos;

        public UC_Action()
        {
            InitializeComponent();
            ucInfos = new List<UC_Info> { };
            cbObject.SelectedIndex = 0;
            
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string a = cbObject.SelectedItem.ToString();

            // Them ket qua tim kiem
            
            using (QuanLyBenhVienDataContext db = new QuanLyBenhVienDataContext()) {
                if (tb == 1)
                {
                    if (cbObject.SelectedIndex == 1)
                    {
                        var search = from bnhan in db.BenhNhans
                                     where SqlMethods.Like(bnhan.HotenBN, "%" + txbSearch.Text + "%")
                                     select bnhan;
                        UC_Info.Dem1 = search.Count();
                        UC_Info.Cbindex = cbObject.SelectedIndex;
                        ucInfos = new List<UC_Info> { };

                        foreach (var bnhansearch in search)
                        {
                            UC_Info uc_info = new UC_Info();
                            uc_info.txbName.Text = bnhansearch.HotenBN;
                            uc_info.txbID.Text = bnhansearch.MaBN.ToString();

                            uc_info.label1.Text = "Ngày sinh:";
                            uc_info.textBox1.Text = ((DateTime)bnhansearch.NgaySinh).ToString("dd.MM.yyyy");

                            uc_info.label2.Text = "Địa chỉ:";
                            uc_info.textBox2.Text = bnhansearch.Diachi;

                            uc_info.label4.Visible = uc_info.textBox4.Visible = true;

                            uc_info.label3.Text = "Giới tính:";
                            uc_info.textBox3.Text = (bool)(bnhansearch.GioiTinh) ? "Nam" : "Nữ";

                            uc_info.label4.Text = "Bệnh";
                            uc_info.textBox4.Text = bnhansearch.MaBenh.ToString();

                            ucInfos.Add(uc_info);
                        }
                        DisplayResult(search.Count());
                    }
                    else
                    {
                        var search = from bsy in db.NhanViens
                                     where SqlMethods.Like(bsy.HotenNV, "%" + txbSearch.Text + "%")
                                     select bsy;
                        UC_Info.Dem1 = search.Count();
                        UC_Info.Cbindex = cbObject.SelectedIndex;
                        ucInfos = new List<UC_Info> { };
                        foreach (var bsysearch in search)
                        {
                            UC_Info uc_info = new UC_Info();
                            uc_info.txbName.Text = bsysearch.HotenNV;
                            uc_info.txbID.Text = bsysearch.MaNV.ToString();

                            uc_info.label1.Text = "Chức danh:";
                            uc_info.textBox1.Text = bsysearch.ChucDanh;

                            uc_info.label2.Text = "Tên khoa:";
                            uc_info.textBox2.Text = bsysearch.TenKhoa;

                            uc_info.label3.Text = "Mã chuyên ngành";
                            uc_info.textBox3.Text = bsysearch.MaChuyenNganh.ToString();

                            uc_info.label4.Visible = uc_info.textBox4.Visible = false;

                            ucInfos.Add(uc_info);
                        }
                        DisplayResult(search.Count());
                    }
                }
                else if(tb == 2)
                {
                    var search = from acc in db.accounts
                                 where SqlMethods.Like(acc.usernamme, "%" + txbSearch.Text + "%")
                                 select acc;
                    UC_Info.Dem1 = search.Count();
                    UC_Info.Cbindex = cbObject.SelectedIndex;
                    ucInfos = new List<UC_Info> { };
                    foreach (var accsearch in search)
                    {
                        UC_Info uc_info = new UC_Info();
                        uc_info.txbName.Text = accsearch.usernamme;
                        ucInfos.Add(uc_info);
                    }
                    DisplayResult(search.Count());
                }
            }
           

        }
        // hien thi toan bo ket qua tim kiem
        public void DisplayResult(int a)
        {
            
            int firstLocationY = 3;
            pnlShow.Controls.Clear();   // Xoa toan bo noi dung tim kiem
            for(int i = 0; i < a; i++)
            {
                bool lastItem = false;
                // Neu da nhan nut delete thi xoa khoi list
                if (ucInfos[i].delete)
                {
                    ucInfos.Remove(ucInfos[i]);
                    if (i == ucInfos.Count)
                        lastItem = true;
                }
                if (!lastItem)
                {
                    ucInfos[i].BackColor = System.Drawing.Color.White;
                    ucInfos[i].Location = new System.Drawing.Point(3, firstLocationY + 79 * i);
                    ucInfos[i].Size = new System.Drawing.Size(509, 73);
                    ucInfos[i].Name = "uC_Info" + i.ToString();
                    ucInfos[i].TabIndex = 3;
                    pnlShow.Controls.Add(ucInfos[i]);
                }
               
            }
        }

        // make accept button for User Control
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnSearch.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void cbObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }
    }

}

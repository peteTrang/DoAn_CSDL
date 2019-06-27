using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_BenhVien.UserControls
{
    public partial class UC_Action : UserControl
    {
        int a = 24;
        private static UC_Action _instace;
        private int dem;
        public static UC_Action Instace {
            get
            {
                if (_instace == null)
                _instace = new UC_Action(); return _instace;
            }
            set { _instace = value; }
        }

        public int Dem { get => dem; set => dem = value; }

        public static List<UC_Info> ucInfos;

        public UC_Action()
        {
            InitializeComponent();
            ucInfos = new List<UC_Info> { };
            //ucInfos.Add(uC_Info1);
            
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

            // Them ket qua tim kiem
            
            using (QuanLyBenhVienDataContext db = new QuanLyBenhVienDataContext()) {
                /*var a = from user in db.accounts
                        where user.admin == false
                        select user;
                a.Count();*/
                
                UC_Info.Dem1 = a;
                ucInfos = new List<UC_Info> { };
                for (int i = 0; i < a; i++)
                {
                    UC_Info uc_info = new UC_Info();
                    uc_info.txbName.Text = "Nguoi so " + i.ToString();
                    ucInfos.Add(uc_info);
                }
                DisplayResult(a);
            }
           

        }
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

    }

}

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
    public partial class UC_Admin : UserControl
    {
        List<UC_Info> ucInfos;
        public UC_Admin()
        {
            InitializeComponent();
            ucInfos = new List<UC_Info> { };
        }

        public void DisplayResult(int a)
        {

            int firstLocationY = 3;
            pnlShow.Controls.Clear();   // Xoa toan bo noi dung tim kiem
            for (int i = 0; i < a; i++)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int a = 64;
            for(int i = 0; i < a; i++)
            {
                UC_Info ucinfo = new UC_Info();
                ucInfos.Add(ucinfo);
            }
            DisplayResult(a);
        }

        private void uC_Info1_Load(object sender, EventArgs e)
        {

        }
    }
}

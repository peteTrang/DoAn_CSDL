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
        List<UC_Info> ucInfos;
        public UC_Action()
        {
            InitializeComponent();
            ucInfos = new List<UC_Info> { };
            ucInfos.Add(uC_Info1);
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {


            UC_Info uc_info = new UC_Info();
            int lastLocationY = ucInfos.Last().Location.Y;
            ucInfos.Add(uc_info);
            pnlShow.Controls.Add(ucInfos.Last());
            ucInfos.Last().BackColor = System.Drawing.Color.White;
            ucInfos.Last().Location = new System.Drawing.Point(3, lastLocationY + 79);
            ucInfos.Last().Name = "uC_Info" + (ucInfos.Count + 1).ToString();
            ucInfos.Last().Size = new System.Drawing.Size(509, 73);
            ucInfos.Last().TabIndex = 0;
            ucInfos.Last().txbName.Text = "User" + (ucInfos.Count).ToString();
        }
    }
}

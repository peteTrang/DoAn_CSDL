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

        public static int Dem1 { get => _dem1; set => _dem1 = value; }

        public UC_Info()
        {
            InitializeComponent();
             delete = false;

        }

        public void btnDelete_Click(object sender, EventArgs e)
        {
            delete = true;
            //UC_Action.Instace.pnlShow = new Panel();
            _dem1 = _dem1 - 1;
            //int c = UC_Action.ucInfos.Count;
            UC_Action hao = (UC_Action)this.Parent.Parent;
            //var a = this.Parent.Parent;
            hao.DisplayResult(_dem1);
            //UC_Action.Instace.pnlShow.Refresh();
            //txbID
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}

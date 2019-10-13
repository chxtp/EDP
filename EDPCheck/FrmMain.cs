using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDPCheck
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            EDPCheck.Helper.FrmHelper.SetPenetrate(this);//设置窗体具有鼠标穿透效果
            EDPCheckHelper.LocalIP = EDPCheck.Helper.NetHelper.GetLocalIP();
        }

    }
}

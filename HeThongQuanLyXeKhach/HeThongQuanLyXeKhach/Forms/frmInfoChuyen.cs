using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyXeKhach
{
    public partial class frmInfoChuyen : Form
    {
        public frmInfoChuyen()
        {
            InitializeComponent();
        }

        private void btnFindInfoTrip_Click(object sender, EventArgs e)
        {
            frmChonGhe frmChonGhe = new frmChonGhe();
            frmChonGhe.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Satis.Entities.Context;
using Satis.Entities.Data_Access;

namespace Satis.BackOffice.Cari
{
    public partial class FrmCariSec : Form
    {
        CariDAL cariDal = new CariDAL();
        SatisContext context = new SatisContext();
        public List<Entities.Tables.Cari> _secilen = new List<Entities.Tables.Cari>();
        public FrmCariSec(bool cokluSecim = false)
        {
            InitializeComponent();
            if (cokluSecim)
            {
                lblUyari.Visible = true;
                gridCariler.OptionsSelection.MultiSelect = true;
            }
        }

        private void FrmCariSec_Load(object sender, EventArgs e)
        {
            gridContCariler.DataSource = cariDal.GetCariler(context);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            foreach (var row in gridCariler.GetSelectedRows())
            {
                string cariKodu = gridCariler.GetRowCellValue(row, colCariKodu).ToString();
                _secilen.Add(context.Cariler.SingleOrDefault(c => c.CariKodu == cariKodu));
            }
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

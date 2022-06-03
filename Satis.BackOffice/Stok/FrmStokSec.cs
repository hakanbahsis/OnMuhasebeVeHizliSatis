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

namespace Satis.BackOffice.Stok
{
    public partial class FrmStokSec : Form
    {
         StokDAL stokDal = new StokDAL();
         SatisContext context = new SatisContext();
         public List<Entities.Tables.Stok> _secilen = new List<Entities.Tables.Stok>();
        public FrmStokSec(bool cokluSecim=false)
        {
            InitializeComponent();
            if (cokluSecim)
            {
                lblUyari.Visible = true;
                gridStoklar.OptionsSelection.MultiSelect = true;
            }
            
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void FrmStokSec_Load(object sender, EventArgs e)
        {
            gridcontStoklar.DataSource = stokDal.GetAllJoin(context);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            foreach (var row in gridStoklar.GetSelectedRows())
            {
                string stokkodu = gridStoklar.GetRowCellValue(row, colStokKodu).ToString();
                _secilen.Add(context.Stoklar.SingleOrDefault(c=>c.StokKodu==stokkodu));
            }
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAcces;

namespace WarehouseProgram
{
    public partial class frmLista : Form
    {
        public frmLista()
        {
            InitializeComponent();
        }
        private void frmLista_Load(object sender, EventArgs e)
        {
            GetListMaterial();
        }
        private void GetListMaterial()
        {
            DataMaterial dataMaterial = new DataMaterial();

            dataGridView1.DataSource = dataMaterial.MaterialsList();
        }
    }
}

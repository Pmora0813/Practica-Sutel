using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sutel_Sln
{
    public partial class frmPricipal : Form
    {
        
        ISutel Proveedor;

        public frmPricipal()
        {
            InitializeComponent();
            NombreColumna();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            mskNumero.Text = "";
            npdMinutos.Value = 0;

            rbtnClaro.Checked = false;
            rbtnkolbi.Checked = false;
            rbtnmovistar.Checked = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            calcularFactura();
        }

        public void NombreColumna()
        {
            dgvTelefonos.ColumnCount = 4;
            dgvTelefonos.ColumnHeadersVisible = true;
            dgvTelefonos.Columns[0].Name = "Proveedor";
            dgvTelefonos.Columns[1].Name = "Número";
            dgvTelefonos.Columns[2].Name = "Minutos";
            dgvTelefonos.Columns[3].Name = "Total";
        }

        private void calcularFactura()
        {



            if (rbtnkolbi.Checked)
            {
                Proveedor = new Kolbi();
                Proveedor.minutos = Convert.ToInt32(npdMinutos.Value);
                Proveedor.numTelefono = Convert.ToInt32(mskNumero.Text.Trim());

                dgvTelefonos.Rows.Add(Proveedor.Proveedor, Proveedor.numTelefono, Proveedor.minutos, Proveedor.calcularFactura());
            }
            else
            {
                if (rbtnClaro.Checked)
                {
                    Proveedor = new Claro();
                    Proveedor.minutos = Convert.ToInt32(npdMinutos.Value);
                    Proveedor.numTelefono = Convert.ToInt32(mskNumero.Text.Trim());

                    dgvTelefonos.Rows.Add(Proveedor.Proveedor, Proveedor.numTelefono, Proveedor.minutos, Proveedor.calcularFactura());
                }
                else
                {
                    if (rbtnmovistar.Checked)
                    {
                        Proveedor = new Movistar();
                        Proveedor.minutos = Convert.ToInt32(npdMinutos.Value);
                        Proveedor.numTelefono = Convert.ToInt32(mskNumero.Text.Trim());

                        dgvTelefonos.Rows.Add(Proveedor.Proveedor, Proveedor.numTelefono, Proveedor.minutos, Proveedor.calcularFactura());


                    }
                }
            }


        }
    }
}

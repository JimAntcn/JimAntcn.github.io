using DataAccess;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication3.CRUD
{
    public partial class Del : DevExpress.XtraEditors.XtraForm
    {

        internal string codestacionSelect;
        
        public Del()
        {
            InitializeComponent();
          
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Del_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            try
            {
                DACRUD.ConsultaEstaciones(ds);
                LlenarLookup(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error al conectarse con el servidor");
            }

        }


        private void LlenarLookup(DataTable dt)
        {
            cbCodigo.EditValue = null;
            cbCodigo.Properties.DataSource = null;
            cbCodigo.Properties.DataSource = dt;
            cbCodigo.Properties.ValueMember = "Cod_Hidro";
            cbCodigo.Properties.DisplayMember = "Estacion";

            cbCodigo.Properties.NullText = "(Escoge/escribe una Estacion)";
        }

        public void estacionSeleccionada()
        {
            cbCodigo.EditValue = codestacionSelect;
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbCodigo.Text))
            {
                DACRUD.BorrarEstacion(cbCodigo.Text); 
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(Consulta))
                    {
                        ((Consulta)form).DataEstaciones();
                        form.Activate();
                        form.BringToFront();
                    }
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione una Estacion");
            }
        }
    }
}
using DataAccess;

using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication3.CRUD
{
    public partial class Consulta : DevExpress.XtraEditors.XtraForm
    {



        public Consulta()
        {
            InitializeComponent();
        }

                
        public void DataEstaciones()
        {
            DataSet ds = new DataSet();
            try
            {
                DACRUD.ConsultaSql(ds);

                gridControl1.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error al conectarse con el servidor");
            }
        }

        public string CodigoDeEstacionSeleccionada()
        {
            DataRow row = gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);

            string codhidro = row.Field<string>("Cod_Hidro");
            return codhidro;
        }
        private void Consulta_Load(object sender, EventArgs e)
        {
            DataEstaciones();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Del))
                {
                    ((Del)form).codestacionSelect = CodigoDeEstacionSeleccionada();
                    ((Del)form).estacionSeleccionada();
                }
                if (form.GetType() == typeof(Actualizar))
                {
                    ((Actualizar)form).codestacionSelect = CodigoDeEstacionSeleccionada();
                    ((Actualizar)form).DatosDeEstacionSeleccionadaDesdeTabla();                   
                }
            }
        }
    }
}
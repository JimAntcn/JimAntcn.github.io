using DataAccess;
using DevExpress.XtraEditors;
using Entities;
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
    public partial class Actualizar : DevExpress.XtraEditors.XtraForm
    {

        Estacion estacion;
        internal string codestacionSelect;

        public Actualizar()
        {
            InitializeComponent();
        }

        private void Actualizar_Load(object sender, EventArgs e)
        {
            LlenarLookup();
            DesactivarControls();
        }

        private void LlenarLookup()
        {
            DataSet ds = new DataSet();
            try
            {
                DACRUD.ConsultaEstaciones(ds);

                lookUpEstacion.EditValue = null;
                lookUpEstacion.Properties.DataSource = null;
                lookUpEstacion.Properties.DataSource = ds.Tables[0];
                lookUpEstacion.Properties.ValueMember = "Cod_Hidro";
                lookUpEstacion.Properties.DisplayMember = "Estacion";

                lookUpEstacion.Properties.NullText = "(Escoge/escribe una Estacion)";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error al conectarse con el servidor");
            }

            
        }

     
        private void lookUpEstacion_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lookUpEstacion.Text))
            {
                LlenarComboBoxes();
                ActivarControls();
                MostrarDatosDeEstacionSeleccionada();             
            }
            else
            {
                DesactivarControls();
                LimpiarControles();
            }
        }


        private void ActivarControls()
        {
            spinCodigo.Enabled = true;
            cbRio.Enabled = true;
            cbCuenca.Enabled = true;
            spAncho.Enabled = true;
            spAlto.Enabled = true;
            textDep.Enabled = true;
            textProv.Enabled = true;
        }

        private void DesactivarControls()
        {
            spinCodigo.Enabled = false;
            cbRio.Enabled = false;
            cbCuenca.Enabled = false;
            spAncho.Enabled = false;
            spAlto.Enabled = false;
            textDep.Enabled = false;
            textProv.Enabled = false;
        }
        public void LlenarComboBoxes()
        {
            DataSet ds = new DataSet();
            try
            {
                DACRUD.ConsultaRioYCuenca(ds);

                cbRio.DataSource = ds.Tables[0];
                cbRio.DisplayMember = "Rio";


                cbCuenca.DataSource = ds.Tables[1];
                cbCuenca.DisplayMember = "Cuenca";

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error al conectarse con el servidor");
            }
        }

        public void MostrarDatosDeEstacionSeleccionada()
        {            
            try
            {
                estacion = DACRUD.DatosDeEstacion(lookUpEstacion.EditValue.ToString());
                spinCodigo.Value = Convert.ToInt32(estacion.CodHidro);
                cbRio.SelectedIndex = cbRio.FindStringExact(estacion.Rio);
                cbCuenca.SelectedIndex = cbCuenca.FindStringExact(estacion.Cuenca) ;
                spAncho.Value = (decimal)estacion.Ancho;
                spAlto.Value = (decimal)estacion.Alto;
                textDep.Text = estacion.Dpto.Trim();
                textProv.Text = estacion.Prov.Trim();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LimpiarControles()
        {
            spinCodigo.Value = 0;
            cbRio.DataSource = null;
            cbCuenca.DataSource = null;
            spAncho.Value = 0;
            spAlto.Value = 0;
            textDep.Text = "";
            textProv.Text = "";
        }

        private void Modificacion(object sender, EventArgs e)
        {
           
        }

        internal void DatosDeEstacionSeleccionadaDesdeTabla()
        {
            lookUpEstacion.EditValue = codestacionSelect;
            MostrarDatosDeEstacionSeleccionada();
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Estacion estacion = new Estacion()
                {
                    Nombre = lookUpEstacion.Text,
                    CodHidro = spinCodigo.Value.ToString(),
                    Rio = cbRio.Text.Trim(),
                    Cuenca = cbCuenca.Text.Trim(),
                    Ancho = Convert.ToDecimal(spAncho.Text),
                    Alto = Convert.ToInt32(spAlto.Text),
                    Dpto = textDep.Text,
                    Prov = textProv.Text
                };
                DACRUD.BorrarEstacion(lookUpEstacion.Text);
                DACRUD.AgregarEstación(estacion);
                XtraMessageBox.Show("Datos Actualizados Correctamente");

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
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error al agregar Estacion");
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
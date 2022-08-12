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
    public partial class Agregar : DevExpress.XtraEditors.XtraForm
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            LlenarComboBoxes();
        }

        private void LlenarComboBoxes()
        {
            DataSet ds = new DataSet();
            try
            {
                DACRUD.ConsultaRioYCuenca(ds);

                comboBox1.DataSource = ds.Tables[0];
                comboBox1.DisplayMember = "Rio";

                comboBox2.DataSource = ds.Tables[1];
                comboBox2.DisplayMember = "Cuenca";


            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error al conectarse con el servidor");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (ValidarCamposObligatorios())
            {
                try
                {
                    Estacion estacion = new Estacion()
                    {
                        Nombre = textEdit1.Text,
                        CodHidro = spinEdit12.Text,
                        Rio = comboBox1.Text,
                        Cuenca = comboBox2.Text,
                        Ancho = Convert.ToDecimal(spinEdit1.Text),
                        Alto = Convert.ToInt32(spinEdit11.Text),
                        Dpto = textEdit3.Text,
                        Prov = textEdit4.Text
                    };
                    DACRUD.AgregarEstación(estacion);
                    XtraMessageBox.Show("Datos Cargados Correctamente");

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
            else
            {
                XtraMessageBox.Show("Completar Campos Obligatorios (*)");
            }
        }


        private bool ValidarCamposObligatorios()
        {
            bool value = true;
            if (String.IsNullOrEmpty(textEdit1.Text)) return !value;
            if (String.IsNullOrEmpty(spinEdit12.Text)) return !value;
            if (String.IsNullOrEmpty(textEdit3.Text)) return !value;
            if (String.IsNullOrEmpty(textEdit4.Text)) return !value;
            return value;
        }
    }
}
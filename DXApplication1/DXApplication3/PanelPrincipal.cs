using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccess;
using DXApplication3.CRUD;

namespace DXApplication3
{
    public partial class HIDROMAN : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public HIDROMAN()
        {
            InitializeComponent();
        }

        
        private void accordionControlElement23_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void accordionControlElement18_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Consulta))
                {
                    ((Consulta)form).DataEstaciones();
                    form.Activate();
                    form.Show();
                    return;
                }
            }

            Consulta consulta = new Consulta();
            consulta.TopLevel = false;  
            consulta.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(consulta);
            consulta.Show();
        }

        private void accordionControlElement19_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Agregar))
                {                   
                    form.Activate();
                    form.BringToFront();
                    form.Show();
                    return;
                }
            }
            Agregar add = new Agregar();
            add.TopLevel = false;
            this.panelPrincipal.Controls.Add(add);
            add.BringToFront();
            add.StartPosition = FormStartPosition.Manual;
            add.Location = new Point((panelPrincipal.Width - add.Width) / 2, (panelPrincipal.Height - add.Height) / 2);
            add.Show();
        }

        private void accordionControlElement20_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Del))
                {
                    form.Activate();
                    form.BringToFront();
                    form.Show();
                    return;
                }
            }

            Del del = new Del();
            del.TopLevel = false;            
            this.panelPrincipal.Controls.Add(del);
            del.BringToFront();
            del.StartPosition = FormStartPosition.Manual;
            del.Location = new Point((panelPrincipal.Width - del.Width) / 2, (panelPrincipal.Height - del.Height) / 2);
            del.Show();

        }

        private void accordionControlElement21_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Actualizar))
                {
                    form.Activate();
                    form.BringToFront();
                    form.Show();
                    return;
                }
            }
            Actualizar updated = new Actualizar();
            updated.TopLevel = false;
            this.panelPrincipal.Controls.Add(updated);
            updated.BringToFront();
            updated.StartPosition = FormStartPosition.Manual;
            updated.Location = new Point((panelPrincipal.Width - updated.Width) / 2, (panelPrincipal.Height - updated.Height) / 2);
            updated.Show();
        }
    }
}

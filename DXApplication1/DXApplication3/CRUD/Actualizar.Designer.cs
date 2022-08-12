
namespace DXApplication3.CRUD
{
    partial class Actualizar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actualizar));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.textProv = new DevExpress.XtraEditors.TextEdit();
            this.spinCodigo = new DevExpress.XtraEditors.SpinEdit();
            this.cbRio = new System.Windows.Forms.ComboBox();
            this.cbCuenca = new System.Windows.Forms.ComboBox();
            this.textDep = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.spAncho = new DevExpress.XtraEditors.SpinEdit();
            this.spAlto = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lookUpEstacion = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAncho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAlto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEstacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lookUpEstacion);
            this.layoutControl1.Controls.Add(this.textProv);
            this.layoutControl1.Controls.Add(this.spinCodigo);
            this.layoutControl1.Controls.Add(this.cbRio);
            this.layoutControl1.Controls.Add(this.cbCuenca);
            this.layoutControl1.Controls.Add(this.textDep);
            this.layoutControl1.Controls.Add(this.simpleButton2);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.spAncho);
            this.layoutControl1.Controls.Add(this.spAlto);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(785, 0, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(379, 297);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem2,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(379, 297);
            this.Root.TextVisible = false;
            // 
            // textProv
            // 
            this.textProv.Location = new System.Drawing.Point(12, 239);
            this.textProv.Name = "textProv";
            this.textProv.Size = new System.Drawing.Size(355, 20);
            this.textProv.StyleController = this.layoutControl1;
            this.textProv.TabIndex = 23;
            this.textProv.TextChanged += new System.EventHandler(this.Modificacion);
            // 
            // spinCodigo
            // 
            this.spinCodigo.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinCodigo.Location = new System.Drawing.Point(93, 61);
            this.spinCodigo.Name = "spinCodigo";
            this.spinCodigo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinCodigo.Size = new System.Drawing.Size(274, 20);
            this.spinCodigo.StyleController = this.layoutControl1;
            this.spinCodigo.TabIndex = 20;
            this.spinCodigo.TextChanged += new System.EventHandler(this.Modificacion);
            // 
            // cbRio
            // 
            this.cbRio.FormattingEnabled = true;
            this.cbRio.Location = new System.Drawing.Point(93, 85);
            this.cbRio.Name = "cbRio";
            this.cbRio.Size = new System.Drawing.Size(274, 21);
            this.cbRio.TabIndex = 19;
            this.cbRio.TextChanged += new System.EventHandler(this.Modificacion);
            // 
            // cbCuenca
            // 
            this.cbCuenca.FormattingEnabled = true;
            this.cbCuenca.Location = new System.Drawing.Point(93, 110);
            this.cbCuenca.Name = "cbCuenca";
            this.cbCuenca.Size = new System.Drawing.Size(274, 21);
            this.cbCuenca.TabIndex = 18;
            this.cbCuenca.TextChanged += new System.EventHandler(this.Modificacion);
            // 
            // textDep
            // 
            this.textDep.Location = new System.Drawing.Point(12, 199);
            this.textDep.Name = "textDep";
            this.textDep.Size = new System.Drawing.Size(355, 20);
            this.textDep.StyleController = this.layoutControl1;
            this.textDep.TabIndex = 17;
            this.textDep.TextChanged += new System.EventHandler(this.Modificacion);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(191, 263);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(176, 22);
            this.simpleButton2.StyleController = this.layoutControl1;
            this.simpleButton2.TabIndex = 16;
            this.simpleButton2.Text = "Salir";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 263);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(175, 22);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "Actualizar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // spAncho
            // 
            this.spAncho.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spAncho.Location = new System.Drawing.Point(93, 135);
            this.spAncho.Name = "spAncho";
            this.spAncho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spAncho.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spAncho.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spAncho.Properties.MaskSettings.Set("mask", "\"f0\"");
            this.spAncho.Size = new System.Drawing.Size(274, 20);
            this.spAncho.StyleController = this.layoutControl1;
            this.spAncho.TabIndex = 21;
            this.spAncho.TextChanged += new System.EventHandler(this.Modificacion);
            // 
            // spAlto
            // 
            this.spAlto.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spAlto.Location = new System.Drawing.Point(93, 159);
            this.spAlto.Name = "spAlto";
            this.spAlto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spAlto.Properties.NullText = "[Escribe un codigo]";
            this.spAlto.Size = new System.Drawing.Size(274, 20);
            this.spAlto.StyleController = this.layoutControl1;
            this.spAlto.TabIndex = 22;
            this.spAlto.TextChanged += new System.EventHandler(this.Modificacion);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textProv;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 211);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(359, 40);
            this.layoutControlItem2.Text = "Provincia";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.spinCodigo;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 49);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(359, 24);
            this.layoutControlItem3.Text = "Codigo";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbRio;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 73);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(359, 25);
            this.layoutControlItem4.Text = "Rio";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cbCuenca;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 98);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(359, 25);
            this.layoutControlItem5.Text = "Cuenca";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.textDep;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 171);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(359, 40);
            this.layoutControlItem6.Text = "Departamento";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.simpleButton2;
            this.layoutControlItem7.Location = new System.Drawing.Point(179, 251);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(180, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.simpleButton1;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 251);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(179, 26);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.spAncho;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 123);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(359, 24);
            this.layoutControlItem9.Text = "Ancho";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.spAlto;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 147);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(359, 24);
            this.layoutControlItem10.Text = "Alto";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(69, 13);
            // 
            // lookUpEstacion
            // 
            this.lookUpEstacion.Location = new System.Drawing.Point(12, 37);
            this.lookUpEstacion.Name = "lookUpEstacion";
            this.lookUpEstacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEstacion.Properties.NullText = "[Escoge una Estacion]";
            this.lookUpEstacion.Size = new System.Drawing.Size(355, 20);
            this.lookUpEstacion.StyleController = this.layoutControl1;
            this.lookUpEstacion.TabIndex = 24;
            this.lookUpEstacion.EditValueChanged += new System.EventHandler(this.lookUpEstacion_EditValueChanged);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lookUpEstacion;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(359, 49);
            this.layoutControlItem1.Text = "Estacion";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(69, 13);
            // 
            // Actualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 297);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Actualizar.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Actualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar";
            this.Load += new System.EventHandler(this.Actualizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAncho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAlto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEstacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        public DevExpress.XtraEditors.TextEdit textProv;
        public DevExpress.XtraEditors.SpinEdit spinCodigo;
        public System.Windows.Forms.ComboBox cbRio;
        public System.Windows.Forms.ComboBox cbCuenca;
        public DevExpress.XtraEditors.TextEdit textDep;
        public DevExpress.XtraEditors.SimpleButton simpleButton2;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
        public DevExpress.XtraEditors.SpinEdit spAncho;
        public DevExpress.XtraEditors.SpinEdit spAlto;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        public DevExpress.XtraEditors.LookUpEdit lookUpEstacion;
    }
}
namespace AgroSys
{
    partial class EliminarProductos
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
            this.components = new System.ComponentModel.Container();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.txtP = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtD = new System.Windows.Forms.RichTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtN = new Telerik.WinControls.UI.RadTextBox();
            this.productos = new AgroSys.Productos();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new AgroSys.ProductosTableAdapters.productoTableAdapter();
            this.proveedor = new AgroSys.Proveedor();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorTableAdapter = new AgroSys.ProveedorTableAdapters.proveedorTableAdapter();
            this.productoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel8
            // 
            this.radLabel8.Font = new System.Drawing.Font("Verdana", 12F);
            this.radLabel8.Location = new System.Drawing.Point(107, 32);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.Size = new System.Drawing.Size(403, 23);
            this.radLabel8.TabIndex = 91;
            this.radLabel8.Text = "Ingrese el Nombre o ID del producto A Eliminar";
            this.radLabel8.ThemeName = "Windows8";
            // 
            // radLabel9
            // 
            this.radLabel9.Font = new System.Drawing.Font("Verdana", 8F);
            this.radLabel9.Location = new System.Drawing.Point(255, 580);
            this.radLabel9.Name = "radLabel9";
            this.radLabel9.Size = new System.Drawing.Size(103, 16);
            this.radLabel9.TabIndex = 96;
            this.radLabel9.Text = "Eliminar Producto";
            this.radLabel9.ThemeName = "Windows8";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::AgroSys.Properties.Resources.delete;
            this.pictureBox5.Location = new System.Drawing.Point(12, 18);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(89, 86);
            this.pictureBox5.TabIndex = 101;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AgroSys.Properties.Resources.deleteFomr;
            this.pictureBox4.Location = new System.Drawing.Point(281, 517);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 57);
            this.pictureBox4.TabIndex = 95;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AgroSys.Properties.Resources.Logo_sistema_AgroSysDesktopModulos;
            this.pictureBox3.Location = new System.Drawing.Point(516, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(104, 115);
            this.pictureBox3.TabIndex = 92;
            this.pictureBox3.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.productoBindingSource1;
            this.comboBox2.DisplayMember = "nombre_producto";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(173, 94);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(257, 21);
            this.comboBox2.TabIndex = 114;
            this.comboBox2.ValueMember = "id_producto";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AgroSys.Properties.Resources.searchForm;
            this.pictureBox1.Location = new System.Drawing.Point(253, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 45);
            this.pictureBox1.TabIndex = 113;
            this.pictureBox1.TabStop = false;
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(352, 512);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(110, 24);
            this.radButton1.TabIndex = 111;
            this.radButton1.Text = "radButton1";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // txtP
            // 
            this.txtP.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtP.Location = new System.Drawing.Point(298, 402);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(188, 27);
            this.txtP.TabIndex = 110;
            this.txtP.ThemeName = "Office2010Black";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Verdana", 12F);
            this.radLabel4.Location = new System.Drawing.Point(134, 402);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(58, 23);
            this.radLabel4.TabIndex = 109;
            this.radLabel4.Text = "Precio";
            this.radLabel4.ThemeName = "Windows8";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.proveedorBindingSource;
            this.comboBox1.DisplayMember = "nombre_proveedor";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(298, 443);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 21);
            this.comboBox1.TabIndex = 108;
            this.comboBox1.ValueMember = "id_proveedor";
            // 
            // txtD
            // 
            this.txtD.BackColor = System.Drawing.Color.LightGray;
            this.txtD.Location = new System.Drawing.Point(298, 268);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(188, 96);
            this.txtD.TabIndex = 106;
            this.txtD.Text = "";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Verdana", 12F);
            this.radLabel3.Location = new System.Drawing.Point(134, 443);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(91, 23);
            this.radLabel3.TabIndex = 105;
            this.radLabel3.Text = "Proveedor";
            this.radLabel3.ThemeName = "Aqua";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Verdana", 12F);
            this.radLabel2.Location = new System.Drawing.Point(134, 268);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(66, 23);
            this.radLabel2.TabIndex = 104;
            this.radLabel2.Text = "Detalle";
            this.radLabel2.ThemeName = "Aqua";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Verdana", 12F);
            this.radLabel1.Location = new System.Drawing.Point(134, 219);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(73, 23);
            this.radLabel1.TabIndex = 103;
            this.radLabel1.Text = "Nombre";
            this.radLabel1.ThemeName = "Windows8";
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtN.Location = new System.Drawing.Point(298, 217);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(188, 27);
            this.txtN.TabIndex = 102;
            this.txtN.ThemeName = "Office2010Black";
            // 
            // productos
            // 
            this.productos.DataSetName = "Productos";
            this.productos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "producto";
            this.productoBindingSource.DataSource = this.productos;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // proveedor
            // 
            this.proveedor.DataSetName = "Proveedor";
            this.proveedor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "proveedor";
            this.proveedorBindingSource.DataSource = this.proveedor;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // productoBindingSource1
            // 
            this.productoBindingSource1.DataMember = "producto";
            this.productoBindingSource1.DataSource = this.productos;
            // 
            // EliminarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 610);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.radLabel9);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.radLabel8);
            this.Controls.Add(this.pictureBox3);
            this.Name = "EliminarProductos";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "EliminarProductos";
            this.ThemeName = "Aqua";
            this.Load += new System.EventHandler(this.EliminarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Telerik.WinControls.UI.RadLabel radLabel9;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadTextBox txtP;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox txtD;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtN;
        private Productos productos;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private ProductosTableAdapters.productoTableAdapter productoTableAdapter;
        private Proveedor proveedor;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private ProveedorTableAdapters.proveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.BindingSource productoBindingSource1;
    }
}

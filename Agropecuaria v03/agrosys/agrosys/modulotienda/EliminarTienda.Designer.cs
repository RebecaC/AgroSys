namespace AgroSys
{
    partial class EliminarTienda
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
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.radLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new Telerik.WinControls.UI.RadButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tiendaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tiendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tienda = new AgroSys.Tienda();
            this.radLabel10 = new Telerik.WinControls.UI.RadLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtN = new Telerik.WinControls.UI.RadTextBox();
            this.txtT = new Telerik.WinControls.UI.RadTextBox();
            this.txtD = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.tiendaTableAdapter = new AgroSys.TiendaTableAdapters.tiendaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tienda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::AgroSys.Properties.Resources.delete;
            this.pictureBox5.Location = new System.Drawing.Point(4, 9);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(89, 86);
            this.pictureBox5.TabIndex = 98;
            this.pictureBox5.TabStop = false;
            // 
            // radLabel8
            // 
            this.radLabel8.Font = new System.Drawing.Font("Verdana", 12F);
            this.radLabel8.Location = new System.Drawing.Point(99, 22);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.Size = new System.Drawing.Size(362, 23);
            this.radLabel8.TabIndex = 94;
            this.radLabel8.Text = "Ingrese el Nombre ó ID de Tienda A Editar";
            this.radLabel8.ThemeName = "Windows8";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AgroSys.Properties.Resources.Logo_sistema_AgroSysDesktopModulos;
            this.pictureBox3.Location = new System.Drawing.Point(493, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(104, 115);
            this.pictureBox3.TabIndex = 95;
            this.pictureBox3.TabStop = false;
            // 
            // radLabel9
            // 
            this.radLabel9.Font = new System.Drawing.Font("Verdana", 8F);
            this.radLabel9.Location = new System.Drawing.Point(254, 435);
            this.radLabel9.Name = "radLabel9";
            this.radLabel9.Size = new System.Drawing.Size(92, 16);
            this.radLabel9.TabIndex = 100;
            this.radLabel9.Text = "Eliminar Tienda";
            this.radLabel9.ThemeName = "Windows8";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AgroSys.Properties.Resources.deleteFomr;
            this.pictureBox4.Location = new System.Drawing.Point(275, 363);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 57);
            this.pictureBox4.TabIndex = 99;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(50, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 37);
            this.label1.TabIndex = 100;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(368, 378);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(110, 24);
            this.btnOK.TabIndex = 99;
            this.btnOK.Text = "radButton1";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tiendaBindingSource1;
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(306, 21);
            this.comboBox1.TabIndex = 98;
            this.comboBox1.ValueMember = "id_tienda";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // tiendaBindingSource1
            // 
            this.tiendaBindingSource1.DataMember = "tienda";
            this.tiendaBindingSource1.DataSource = this.tiendaBindingSource;
            // 
            // tiendaBindingSource
            // 
            this.tiendaBindingSource.DataSource = this.tienda;
            this.tiendaBindingSource.Position = 0;
            // 
            // tienda
            // 
            this.tienda.DataSetName = "Tienda";
            this.tienda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radLabel10
            // 
            this.radLabel10.Font = new System.Drawing.Font("Verdana", 8F);
            this.radLabel10.Location = new System.Drawing.Point(298, 183);
            this.radLabel10.Name = "radLabel10";
            this.radLabel10.Size = new System.Drawing.Size(43, 16);
            this.radLabel10.TabIndex = 96;
            this.radLabel10.Text = "Buscar";
            this.radLabel10.ThemeName = "Windows8";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AgroSys.Properties.Resources.searchForm;
            this.pictureBox2.Location = new System.Drawing.Point(298, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 45);
            this.pictureBox2.TabIndex = 94;
            this.pictureBox2.TabStop = false;
            // 
            // txtN
            // 
            this.txtN.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtN.Location = new System.Drawing.Point(298, 205);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(188, 27);
            this.txtN.TabIndex = 88;
            this.txtN.ThemeName = "Office2010Black";
            this.txtN.UseWaitCursor = true;
            // 
            // txtT
            // 
            this.txtT.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtT.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtT.Location = new System.Drawing.Point(298, 300);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(188, 27);
            this.txtT.TabIndex = 93;
            this.txtT.ThemeName = "Office2010Black";
            this.txtT.UseWaitCursor = true;
            // 
            // txtD
            // 
            this.txtD.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtD.Location = new System.Drawing.Point(298, 254);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(188, 27);
            this.txtD.TabIndex = 92;
            this.txtD.ThemeName = "Office2010Black";
            this.txtD.UseWaitCursor = true;
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Verdana", 12F);
            this.radLabel6.Location = new System.Drawing.Point(134, 300);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(78, 23);
            this.radLabel6.TabIndex = 91;
            this.radLabel6.Text = "Teléfono";
            this.radLabel6.ThemeName = "Aqua";
            this.radLabel6.UseWaitCursor = true;
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Verdana", 12F);
            this.radLabel5.Location = new System.Drawing.Point(134, 254);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(84, 23);
            this.radLabel5.TabIndex = 90;
            this.radLabel5.Text = "Dirección";
            this.radLabel5.ThemeName = "Aqua";
            this.radLabel5.UseWaitCursor = true;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Verdana", 12F);
            this.radLabel2.Location = new System.Drawing.Point(134, 209);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(73, 23);
            this.radLabel2.TabIndex = 89;
            this.radLabel2.Text = "Nombre";
            this.radLabel2.ThemeName = "Windows8";
            this.radLabel2.UseWaitCursor = true;
            // 
            // tiendaTableAdapter
            // 
            this.tiendaTableAdapter.ClearBeforeFill = true;
            // 
            // EliminarTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 493);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radLabel9);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.radLabel8);
            this.Controls.Add(this.radLabel10);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.txtT);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.txtD);
            this.Name = "EliminarTienda";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "EliminarTienda";
            this.ThemeName = "Aqua";
            this.Load += new System.EventHandler(this.EliminarTienda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tienda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private Telerik.WinControls.UI.RadLabel radLabel8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Telerik.WinControls.UI.RadLabel radLabel9;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton btnOK;
        private System.Windows.Forms.ComboBox comboBox1;
        private Telerik.WinControls.UI.RadLabel radLabel10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Telerik.WinControls.UI.RadTextBox txtN;
        private Telerik.WinControls.UI.RadTextBox txtT;
        private Telerik.WinControls.UI.RadTextBox txtD;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private System.Windows.Forms.BindingSource tiendaBindingSource;
        private Tienda tienda;
        private System.Windows.Forms.BindingSource tiendaBindingSource1;
        private TiendaTableAdapters.tiendaTableAdapter tiendaTableAdapter;
    }
}

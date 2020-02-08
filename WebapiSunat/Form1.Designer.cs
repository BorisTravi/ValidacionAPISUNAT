namespace WebapiSunat
{
    partial class frmValidarDocumentoSunat
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFechaI = new System.Windows.Forms.Label();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.GridViewListado = new System.Windows.Forms.DataGridView();
            this.colSede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exportar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exporExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewListado)).BeginInit();
            this.Exportar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(912, 31);
            this.txtToken.Multiline = true;
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(119, 100);
            this.txtToken.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblFechaI);
            this.groupBox1.Controls.Add(this.dtFechaFin);
            this.groupBox1.Controls.Add(this.dtFechaInicio);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bucar por fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Fecha Fin";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFechaI
            // 
            this.lblFechaI.AutoSize = true;
            this.lblFechaI.Location = new System.Drawing.Point(6, 29);
            this.lblFechaI.Name = "lblFechaI";
            this.lblFechaI.Size = new System.Drawing.Size(65, 13);
            this.lblFechaI.TabIndex = 22;
            this.lblFechaI.Text = "Fecha Inicio";
            this.lblFechaI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(77, 55);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(84, 20);
            this.dtFechaFin.TabIndex = 21;
            this.dtFechaFin.Value = new System.DateTime(2019, 11, 18, 0, 0, 0, 0);
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicio.Location = new System.Drawing.Point(77, 25);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(84, 20);
            this.dtFechaInicio.TabIndex = 20;
            this.dtFechaInicio.Value = new System.DateTime(2019, 11, 18, 0, 0, 0, 0);
            // 
            // GridViewListado
            // 
            this.GridViewListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSede,
            this.colRuc,
            this.colTipoDoc,
            this.colCodigo,
            this.colSerie,
            this.colNumero,
            this.colFecha,
            this.colMonto,
            this.colResultado});
            this.GridViewListado.ContextMenuStrip = this.Exportar;
            this.GridViewListado.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GridViewListado.Location = new System.Drawing.Point(12, 142);
            this.GridViewListado.Name = "GridViewListado";
            this.GridViewListado.Size = new System.Drawing.Size(843, 285);
            this.GridViewListado.TabIndex = 19;
            // 
            // colSede
            // 
            this.colSede.HeaderText = "Sede";
            this.colSede.Name = "colSede";
            // 
            // colRuc
            // 
            this.colRuc.HeaderText = "Ruc Cliente";
            this.colRuc.Name = "colRuc";
            // 
            // colTipoDoc
            // 
            this.colTipoDoc.HeaderText = "Tipo Doc";
            this.colTipoDoc.Name = "colTipoDoc";
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.Name = "colCodigo";
            // 
            // colSerie
            // 
            this.colSerie.HeaderText = "Serie";
            this.colSerie.Name = "colSerie";
            // 
            // colNumero
            // 
            this.colNumero.HeaderText = "Numero";
            this.colNumero.Name = "colNumero";
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha Emision";
            this.colFecha.Name = "colFecha";
            // 
            // colMonto
            // 
            this.colMonto.HeaderText = "Monto";
            this.colMonto.Name = "colMonto";
            // 
            // colResultado
            // 
            this.colResultado.HeaderText = "Respuesta Sunat";
            this.colResultado.Name = "colResultado";
            // 
            // Exportar
            // 
            this.Exportar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exporExcel});
            this.Exportar.Name = "Exportar";
            this.Exportar.Size = new System.Drawing.Size(145, 26);
            this.Exportar.Click += new System.EventHandler(this.Exportar_Click);
            // 
            // exporExcel
            // 
            this.exporExcel.Name = "exporExcel";
            this.exporExcel.Size = new System.Drawing.Size(144, 22);
            this.exporExcel.Text = "Expotar Excel";
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Location = new System.Drawing.Point(6, 27);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(209, 21);
            this.cboTipoDoc.TabIndex = 29;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(457, 40);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(99, 43);
            this.btnListar.TabIndex = 28;
            this.btnListar.Text = "Buscar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboTipoDoc);
            this.groupBox2.Location = new System.Drawing.Point(211, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 100);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Documento";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(457, 103);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(99, 23);
            this.btnLimpiar.TabIndex = 32;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(573, 40);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(97, 43);
            this.btnCargar.TabIndex = 33;
            this.btnCargar.Text = "Cargar Data";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // frmValidarDocumentoSunat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 482);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.GridViewListado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtToken);
            this.Name = "frmValidarDocumentoSunat";
            this.Text = "Validar Documentos (SUNAT)";
            this.Load += new System.EventHandler(this.frmValidarDocumentoSunat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewListado)).EndInit();
            this.Exportar.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFechaI;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.DataGridView GridViewListado;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip Exportar;
        private System.Windows.Forms.ToolStripMenuItem exporExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSede;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResultado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCargar;
    }
}


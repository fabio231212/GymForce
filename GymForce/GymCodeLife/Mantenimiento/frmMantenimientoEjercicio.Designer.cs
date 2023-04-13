
namespace Capa.UI.Mantenimiento
{
    partial class frmMantenimientoEjercicio
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
            this.tspMantenimientos = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtTiempoDescanso = new System.Windows.Forms.TextBox();
            this.lblTiempoDescanso = new System.Windows.Forms.Label();
            this.txtSeries = new System.Windows.Forms.TextBox();
            this.lblSeries = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtRepeticiones = new System.Windows.Forms.TextBox();
            this.lblRepeticiones = new System.Windows.Forms.Label();
            this.lblFoto = new System.Windows.Forms.Label();
            this.lblTipoEjercicio = new System.Windows.Forms.Label();
            this.pbFotoEjercicio = new System.Windows.Forms.PictureBox();
            this.cmbEjercicio = new System.Windows.Forms.ComboBox();
            this.lblEntrenamiento = new System.Windows.Forms.Label();
            this.cmbEntrenamiento = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEntrenamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEjercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tspMantenimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoEjercicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // tspMantenimientos
            // 
            this.tspMantenimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.tspMantenimientos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnNuevo,
            this.toolStripBtnEditar,
            this.toolStripBtnEliminar,
            this.toolStripBtnSalir});
            this.tspMantenimientos.Location = new System.Drawing.Point(0, 0);
            this.tspMantenimientos.Name = "tspMantenimientos";
            this.tspMantenimientos.Size = new System.Drawing.Size(1125, 59);
            this.tspMantenimientos.TabIndex = 52;
            this.tspMantenimientos.Text = "toolStrip1";
            // 
            // toolStripBtnNuevo
            // 
            this.toolStripBtnNuevo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnNuevo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripBtnNuevo.Image = global::Capa.UI.Properties.Resources.icons8_new_document_35px;
            this.toolStripBtnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnNuevo.Name = "toolStripBtnNuevo";
            this.toolStripBtnNuevo.Size = new System.Drawing.Size(52, 56);
            this.toolStripBtnNuevo.Text = "Nuevo";
            this.toolStripBtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnNuevo.Click += new System.EventHandler(this.toolStripBtnNuevo_Click);
            // 
            // toolStripBtnEditar
            // 
            this.toolStripBtnEditar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripBtnEditar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripBtnEditar.Image = global::Capa.UI.Properties.Resources.icons8_edit_property_35px;
            this.toolStripBtnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnEditar.Name = "toolStripBtnEditar";
            this.toolStripBtnEditar.Size = new System.Drawing.Size(48, 56);
            this.toolStripBtnEditar.Text = "Editar";
            this.toolStripBtnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripBtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnEditar.Click += new System.EventHandler(this.toolStripBtnEditar_Click);
            // 
            // toolStripBtnEliminar
            // 
            this.toolStripBtnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripBtnEliminar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripBtnEliminar.Image = global::Capa.UI.Properties.Resources.icons8_delete_document_35px;
            this.toolStripBtnEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnEliminar.Name = "toolStripBtnEliminar";
            this.toolStripBtnEliminar.Size = new System.Drawing.Size(63, 56);
            this.toolStripBtnEliminar.Text = "Eliminar";
            this.toolStripBtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnEliminar.Click += new System.EventHandler(this.toolStripBtnEliminar_Click);
            // 
            // toolStripBtnSalir
            // 
            this.toolStripBtnSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripBtnSalir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripBtnSalir.Image = global::Capa.UI.Properties.Resources.icons8_Close_35px;
            this.toolStripBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSalir.Name = "toolStripBtnSalir";
            this.toolStripBtnSalir.Size = new System.Drawing.Size(39, 56);
            this.toolStripBtnSalir.Text = "Salir";
            this.toolStripBtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnSalir.Click += new System.EventHandler(this.toolStripBtnSalir_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 59);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(165)))));
            this.splitContainer1.Panel1.Controls.Add(this.txtTiempoDescanso);
            this.splitContainer1.Panel1.Controls.Add(this.lblTiempoDescanso);
            this.splitContainer1.Panel1.Controls.Add(this.txtSeries);
            this.splitContainer1.Panel1.Controls.Add(this.lblSeries);
            this.splitContainer1.Panel1.Controls.Add(this.lblPeso);
            this.splitContainer1.Panel1.Controls.Add(this.txtPeso);
            this.splitContainer1.Panel1.Controls.Add(this.txtRepeticiones);
            this.splitContainer1.Panel1.Controls.Add(this.lblRepeticiones);
            this.splitContainer1.Panel1.Controls.Add(this.lblFoto);
            this.splitContainer1.Panel1.Controls.Add(this.lblTipoEjercicio);
            this.splitContainer1.Panel1.Controls.Add(this.pbFotoEjercicio);
            this.splitContainer1.Panel1.Controls.Add(this.cmbEjercicio);
            this.splitContainer1.Panel1.Controls.Add(this.lblEntrenamiento);
            this.splitContainer1.Panel1.Controls.Add(this.cmbEntrenamiento);
            this.splitContainer1.Panel1.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel1.Controls.Add(this.btnAceptar);
            this.splitContainer1.Panel1.Controls.Add(this.txtDescripcion);
            this.splitContainer1.Panel1.Controls.Add(this.lblDescripcion);
            this.splitContainer1.Panel1.Controls.Add(this.lblId);
            this.splitContainer1.Panel1.Controls.Add(this.txtId);
            this.splitContainer1.Panel1.Controls.Add(this.txtNombre);
            this.splitContainer1.Panel1.Controls.Add(this.lblNombre);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDatos);
            this.splitContainer1.Size = new System.Drawing.Size(1125, 582);
            this.splitContainer1.SplitterDistance = 427;
            this.splitContainer1.TabIndex = 53;
            // 
            // txtTiempoDescanso
            // 
            this.txtTiempoDescanso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(165)))));
            this.txtTiempoDescanso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTiempoDescanso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempoDescanso.ForeColor = System.Drawing.Color.White;
            this.txtTiempoDescanso.Location = new System.Drawing.Point(114, 325);
            this.txtTiempoDescanso.Name = "txtTiempoDescanso";
            this.txtTiempoDescanso.Size = new System.Drawing.Size(206, 27);
            this.txtTiempoDescanso.TabIndex = 112;
            // 
            // lblTiempoDescanso
            // 
            this.lblTiempoDescanso.AutoSize = true;
            this.lblTiempoDescanso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoDescanso.ForeColor = System.Drawing.Color.LightGray;
            this.lblTiempoDescanso.Location = new System.Drawing.Point(105, 306);
            this.lblTiempoDescanso.Name = "lblTiempoDescanso";
            this.lblTiempoDescanso.Size = new System.Drawing.Size(215, 16);
            this.lblTiempoDescanso.TabIndex = 111;
            this.lblTiempoDescanso.Text = "Tiempo de Descanso(Segundos)";
            this.lblTiempoDescanso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSeries
            // 
            this.txtSeries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(165)))));
            this.txtSeries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSeries.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeries.ForeColor = System.Drawing.Color.White;
            this.txtSeries.Location = new System.Drawing.Point(241, 153);
            this.txtSeries.Name = "txtSeries";
            this.txtSeries.Size = new System.Drawing.Size(133, 27);
            this.txtSeries.TabIndex = 109;
            // 
            // lblSeries
            // 
            this.lblSeries.AutoSize = true;
            this.lblSeries.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeries.ForeColor = System.Drawing.Color.LightGray;
            this.lblSeries.Location = new System.Drawing.Point(238, 134);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(46, 16);
            this.lblSeries.TabIndex = 108;
            this.lblSeries.Text = "Series";
            this.lblSeries.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.ForeColor = System.Drawing.Color.LightGray;
            this.lblPeso.Location = new System.Drawing.Point(241, 6);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(64, 16);
            this.lblPeso.TabIndex = 104;
            this.lblPeso.Text = "Peso(kg)";
            this.lblPeso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(165)))));
            this.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPeso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.ForeColor = System.Drawing.Color.White;
            this.txtPeso.Location = new System.Drawing.Point(241, 25);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(133, 27);
            this.txtPeso.TabIndex = 105;
            // 
            // txtRepeticiones
            // 
            this.txtRepeticiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(165)))));
            this.txtRepeticiones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRepeticiones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepeticiones.ForeColor = System.Drawing.Color.White;
            this.txtRepeticiones.Location = new System.Drawing.Point(241, 83);
            this.txtRepeticiones.Name = "txtRepeticiones";
            this.txtRepeticiones.Size = new System.Drawing.Size(133, 27);
            this.txtRepeticiones.TabIndex = 107;
            // 
            // lblRepeticiones
            // 
            this.lblRepeticiones.AutoSize = true;
            this.lblRepeticiones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeticiones.ForeColor = System.Drawing.Color.LightGray;
            this.lblRepeticiones.Location = new System.Drawing.Point(238, 64);
            this.lblRepeticiones.Name = "lblRepeticiones";
            this.lblRepeticiones.Size = new System.Drawing.Size(91, 16);
            this.lblRepeticiones.TabIndex = 106;
            this.lblRepeticiones.Text = "Repeticiones";
            this.lblRepeticiones.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFoto.Location = new System.Drawing.Point(164, 369);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(115, 16);
            this.lblFoto.TabIndex = 95;
            this.lblFoto.Text = "Seleccionar Foto";
            this.lblFoto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTipoEjercicio
            // 
            this.lblTipoEjercicio.AutoSize = true;
            this.lblTipoEjercicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEjercicio.ForeColor = System.Drawing.Color.LightGray;
            this.lblTipoEjercicio.Location = new System.Drawing.Point(26, 252);
            this.lblTipoEjercicio.Name = "lblTipoEjercicio";
            this.lblTipoEjercicio.Size = new System.Drawing.Size(64, 16);
            this.lblTipoEjercicio.TabIndex = 103;
            this.lblTipoEjercicio.Text = "Ejercicio";
            this.lblTipoEjercicio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbFotoEjercicio
            // 
            this.pbFotoEjercicio.Image = global::Capa.UI.Properties.Resources.icons8_user_120px_1;
            this.pbFotoEjercicio.Location = new System.Drawing.Point(114, 398);
            this.pbFotoEjercicio.Name = "pbFotoEjercicio";
            this.pbFotoEjercicio.Size = new System.Drawing.Size(214, 100);
            this.pbFotoEjercicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoEjercicio.TabIndex = 94;
            this.pbFotoEjercicio.TabStop = false;
            this.pbFotoEjercicio.Click += new System.EventHandler(this.pbFotoUsuario_Click);
            // 
            // cmbEjercicio
            // 
            this.cmbEjercicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(165)))));
            this.cmbEjercicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEjercicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEjercicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEjercicio.ForeColor = System.Drawing.Color.White;
            this.cmbEjercicio.FormattingEnabled = true;
            this.cmbEjercicio.Location = new System.Drawing.Point(30, 271);
            this.cmbEjercicio.Name = "cmbEjercicio";
            this.cmbEjercicio.Size = new System.Drawing.Size(344, 29);
            this.cmbEjercicio.TabIndex = 102;
            // 
            // lblEntrenamiento
            // 
            this.lblEntrenamiento.AutoSize = true;
            this.lblEntrenamiento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrenamiento.ForeColor = System.Drawing.Color.LightGray;
            this.lblEntrenamiento.Location = new System.Drawing.Point(27, 193);
            this.lblEntrenamiento.Name = "lblEntrenamiento";
            this.lblEntrenamiento.Size = new System.Drawing.Size(101, 16);
            this.lblEntrenamiento.TabIndex = 101;
            this.lblEntrenamiento.Text = "Entrenamiento";
            this.lblEntrenamiento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbEntrenamiento
            // 
            this.cmbEntrenamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(165)))));
            this.cmbEntrenamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntrenamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEntrenamiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEntrenamiento.ForeColor = System.Drawing.Color.White;
            this.cmbEntrenamiento.FormattingEnabled = true;
            this.cmbEntrenamiento.Location = new System.Drawing.Point(29, 212);
            this.cmbEntrenamiento.Name = "cmbEntrenamiento";
            this.cmbEntrenamiento.Size = new System.Drawing.Size(345, 29);
            this.cmbEntrenamiento.TabIndex = 100;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(111)))), ((int)(((byte)(120)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Location = new System.Drawing.Point(197, 530);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(167, 40);
            this.btnCancelar.TabIndex = 91;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(111)))), ((int)(((byte)(120)))));
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.LightGray;
            this.btnAceptar.Location = new System.Drawing.Point(15, 530);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(167, 40);
            this.btnAceptar.TabIndex = 90;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(165)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(26, 153);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(136, 27);
            this.txtDescripcion.TabIndex = 89;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.LightGray;
            this.lblDescripcion.Location = new System.Drawing.Point(23, 134);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(85, 16);
            this.lblDescripcion.TabIndex = 88;
            this.lblDescripcion.Text = "Descripción";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.LightGray;
            this.lblId.Location = new System.Drawing.Point(26, 6);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 16);
            this.lblId.TabIndex = 84;
            this.lblId.Text = "Id";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(165)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.White;
            this.txtId.Location = new System.Drawing.Point(28, 25);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(136, 27);
            this.txtId.TabIndex = 85;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(165)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(26, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(136, 27);
            this.txtNombre.TabIndex = 87;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.LightGray;
            this.lblNombre.Location = new System.Drawing.Point(23, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 16);
            this.lblNombre.TabIndex = 86;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Descripcion,
            this.TipoEntrenamiento,
            this.TipoEjercicio});
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 0);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(694, 582);
            this.dgvDatos.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // TipoEntrenamiento
            // 
            this.TipoEntrenamiento.DataPropertyName = "EntrenamientoNombre";
            this.TipoEntrenamiento.HeaderText = "Tipo de Entrenamiento";
            this.TipoEntrenamiento.Name = "TipoEntrenamiento";
            // 
            // TipoEjercicio
            // 
            this.TipoEjercicio.DataPropertyName = "TipoEjercicioNombre";
            this.TipoEjercicio.HeaderText = "Tipo de Ejercicio";
            this.TipoEjercicio.Name = "TipoEjercicio";
            // 
            // frmMantenimientoEjercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 641);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tspMantenimientos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMantenimientoEjercicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMantenimientoEjercicio";
            this.Load += new System.EventHandler(this.frmMantenimientoEjercicio_Load);
            this.tspMantenimientos.ResumeLayout(false);
            this.tspMantenimientos.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoEjercicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspMantenimientos;
        private System.Windows.Forms.ToolStripButton toolStripBtnNuevo;
        private System.Windows.Forms.ToolStripButton toolStripBtnEditar;
        private System.Windows.Forms.ToolStripButton toolStripBtnEliminar;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEntrenamiento;
        private System.Windows.Forms.ComboBox cmbEntrenamiento;
        private System.Windows.Forms.Label lblTipoEjercicio;
        private System.Windows.Forms.ComboBox cmbEjercicio;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.PictureBox pbFotoEjercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEntrenamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEjercicio;
        private System.Windows.Forms.TextBox txtSeries;
        private System.Windows.Forms.Label lblSeries;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtRepeticiones;
        private System.Windows.Forms.Label lblRepeticiones;
        private System.Windows.Forms.TextBox txtTiempoDescanso;
        private System.Windows.Forms.Label lblTiempoDescanso;
    }
}
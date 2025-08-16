namespace Tareas_Diseñador_de_formularios
{
    partial class fmRegistros
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblRegistro = new Label();
            lblNombre = new Label();
            lblCarnet = new Label();
            lblCarrera = new Label();
            cmbCarrera = new ComboBox();
            txtCarnet = new TextBox();
            txtNombre = new TextBox();
            lblLista = new Label();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistro.Location = new Point(96, 26);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(393, 46);
            lblRegistro.TabIndex = 0;
            lblRegistro.Text = "Registro de estudiantes";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(61, 137);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(108, 31);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            lblNombre.Click += lblNombre_Click;
            // 
            // lblCarnet
            // 
            lblCarnet.AutoSize = true;
            lblCarnet.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarnet.Location = new Point(70, 204);
            lblCarnet.Name = "lblCarnet";
            lblCarnet.Size = new Size(90, 31);
            lblCarnet.TabIndex = 2;
            lblCarnet.Text = "Carnet:";
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarrera.Location = new Point(63, 272);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(97, 31);
            lblCarrera.TabIndex = 3;
            lblCarrera.Text = "Carrera:";
            // 
            // cmbCarrera
            // 
            cmbCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Items.AddRange(new object[] { "Administración de Empresas", "Derecho", "Ingeniería en Sistemas ", "Informática", "Medicina", "Contaduría", "Finanzas", "Psicología", "Ingeniería Civil", "Comunicación" });
            cmbCarrera.Location = new Point(223, 274);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(241, 28);
            cmbCarrera.TabIndex = 3;
            cmbCarrera.SelectedIndexChanged += cmbCarrera_SelectedIndexChanged;
            // 
            // txtCarnet
            // 
            txtCarnet.Location = new Point(223, 208);
            txtCarnet.Name = "txtCarnet";
            txtCarnet.Size = new Size(241, 27);
            txtCarnet.TabIndex = 2;
            txtCarnet.TextChanged += txtCarnet_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(223, 136);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(241, 27);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.BorderStyle = BorderStyle.FixedSingle;
            lblLista.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblLista.Location = new Point(42, 392);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(194, 30);
            lblLista.TabIndex = 7;
            lblLista.Text = "Lista de Estudiantes";
            lblLista.Click += label1_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(143, 320);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(129, 47);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(333, 325);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(131, 42);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // fmRegistros
            // 
            AcceptButton = btnAgregar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnLimpiar;
            ClientSize = new Size(580, 488);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregar);
            Controls.Add(lblLista);
            Controls.Add(txtNombre);
            Controls.Add(txtCarnet);
            Controls.Add(cmbCarrera);
            Controls.Add(lblCarrera);
            Controls.Add(lblCarnet);
            Controls.Add(lblNombre);
            Controls.Add(lblRegistro);
            Name = "fmRegistros";
            Text = "Registros de estudiantes";
            Enter += btnAgregar_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistro;
        private Label lblNombre;
        private Label lblCarnet;
        private Label lblCarrera;
        private ComboBox cmbCarrera;
        private TextBox txtCarnet;
        private TextBox txtNombre;
        private Label lblLista;
        private Button btnAgregar;
        private Button btnLimpiar;
    }
}

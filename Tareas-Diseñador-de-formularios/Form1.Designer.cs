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
            lblRegistro.Location = new Point(84, 20);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(319, 37);
            lblRegistro.TabIndex = 0;
            lblRegistro.Text = "Registro de estudiantes";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(53, 103);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(91, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            lblNombre.Click += lblNombre_Click;
            // 
            // lblCarnet
            // 
            lblCarnet.AutoSize = true;
            lblCarnet.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarnet.Location = new Point(61, 153);
            lblCarnet.Name = "lblCarnet";
            lblCarnet.Size = new Size(76, 25);
            lblCarnet.TabIndex = 2;
            lblCarnet.Text = "Carnet:";
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarrera.Location = new Point(55, 204);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(83, 25);
            lblCarrera.TabIndex = 3;
            lblCarrera.Text = "Carrera:";
            // 
            // cmbCarrera
            // 
            cmbCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Items.AddRange(new object[] { "Administración de Empresas", "Derecho", "Ingeniería en Sistemas ", "Informática", "Medicina", "Contaduría", "Finanzas", "Psicología", "Ingeniería Civil", "Comunicación" });
            cmbCarrera.Location = new Point(195, 206);
            cmbCarrera.Margin = new Padding(3, 2, 3, 2);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(211, 23);
            cmbCarrera.TabIndex = 3;
            cmbCarrera.SelectedIndexChanged += cmbCarrera_SelectedIndexChanged;
            // 
            // txtCarnet
            // 
            txtCarnet.Location = new Point(195, 156);
            txtCarnet.Margin = new Padding(3, 2, 3, 2);
            txtCarnet.Name = "txtCarnet";
            txtCarnet.Size = new Size(211, 23);
            txtCarnet.TabIndex = 2;
            txtCarnet.TextChanged += txtCarnet_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(195, 102);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(211, 23);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.BorderStyle = BorderStyle.FixedSingle;
            lblLista.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblLista.Location = new Point(10, 292);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(155, 23);
            lblLista.TabIndex = 7;
            lblLista.Text = "Lista de Estudiantes";
            lblLista.Click += label1_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(125, 240);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(113, 35);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(291, 244);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(115, 32);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // fmRegistros
            // 
            AcceptButton = btnAgregar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnLimpiar;
            ClientSize = new Size(508, 366);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "fmRegistros";
            Text = "Registros de estudiantes";
            Load += fmRegistros_Load;
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

namespace WinFormClienteEjemplo
{
    partial class FormPrincipal
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
            btnCrear = new Button();
            btnListar = new Button();
            btnBorrar = new Button();
            tbId = new TextBox();
            tbNombre = new TextBox();
            tbNota = new TextBox();
            lbId = new Label();
            label2 = new Label();
            label3 = new Label();
            dgvAlumnos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Nota = new DataGridViewTextBoxColumn();
            btnSeleccionar = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(531, 172);
            btnCrear.Margin = new Padding(4);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(114, 60);
            btnCrear.TabIndex = 0;
            btnCrear.Text = "Crear Nuevo";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(531, 247);
            btnListar.Margin = new Padding(4);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(114, 55);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(531, 89);
            btnBorrar.Margin = new Padding(4);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(114, 55);
            btnBorrar.TabIndex = 2;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // tbId
            // 
            tbId.Enabled = false;
            tbId.Location = new Point(127, 21);
            tbId.Name = "tbId";
            tbId.Size = new Size(227, 29);
            tbId.TabIndex = 3;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(127, 65);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(371, 29);
            tbNombre.TabIndex = 4;
            // 
            // tbNota
            // 
            tbNota.Location = new Point(127, 110);
            tbNota.Name = "tbNota";
            tbNota.Size = new Size(95, 29);
            tbNota.TabIndex = 5;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(83, 24);
            lbId.Name = "lbId";
            lbId.Size = new Size(23, 21);
            lbId.TabIndex = 6;
            lbId.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 68);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 7;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 113);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 8;
            label3.Text = "Nota";
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Nota });
            dgvAlumnos.Location = new Point(12, 172);
            dgvAlumnos.MultiSelect = false;
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlumnos.Size = new Size(499, 193);
            dgvAlumnos.TabIndex = 9;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Nota
            // 
            Nota.HeaderText = "Nota";
            Nota.Name = "Nota";
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(531, 310);
            btnSeleccionar.Margin = new Padding(4);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(114, 55);
            btnSeleccionar.TabIndex = 10;
            btnSeleccionar.Text = "Editar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(531, 21);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(114, 60);
            button1.TabIndex = 11;
            button1.Text = "Confirmar registro";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 379);
            Controls.Add(button1);
            Controls.Add(btnSeleccionar);
            Controls.Add(dgvAlumnos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbId);
            Controls.Add(tbNota);
            Controls.Add(tbNombre);
            Controls.Add(tbId);
            Controls.Add(btnBorrar);
            Controls.Add(btnListar);
            Controls.Add(btnCrear);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormPrincipal";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCrear;
        private Button btnListar;
        private Button btnBorrar;
        private TextBox tbId;
        private TextBox tbNombre;
        private TextBox tbNota;
        private Label lbId;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Nota;
        private Button btnSeleccionar;
        protected internal DataGridView dgvAlumnos;
        private Button button1;
    }
}

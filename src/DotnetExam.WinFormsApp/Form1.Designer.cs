namespace DotnetExam.WinFormsApp
{
    partial class Form1
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
            btnBuscar = new Button();
            dgMaterias = new DataGridView();
            dgAlumnos = new DataGridView();
            txtBusquedaMateria = new TextBox();
            label1 = new Label();
            lblMaterias = new Label();
            lblAlumnos = new Label();
            ((System.ComponentModel.ISupportInitialize)dgMaterias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgAlumnos).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(378, 29);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgMaterias
            // 
            dgMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMaterias.Location = new Point(12, 92);
            dgMaterias.Name = "dgMaterias";
            dgMaterias.RowTemplate.Height = 25;
            dgMaterias.Size = new Size(360, 346);
            dgMaterias.TabIndex = 1;
            dgMaterias.CellClick += dgMaterias_CellClick;
            // 
            // dgAlumnos
            // 
            dgAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAlumnos.Location = new Point(409, 92);
            dgAlumnos.Name = "dgAlumnos";
            dgAlumnos.RowTemplate.Height = 25;
            dgAlumnos.Size = new Size(360, 346);
            dgAlumnos.TabIndex = 2;
            dgAlumnos.CellFormatting += dgAlumnos_CellFormatting;
            // 
            // txtBusquedaMateria
            // 
            txtBusquedaMateria.Location = new Point(12, 30);
            txtBusquedaMateria.Name = "txtBusquedaMateria";
            txtBusquedaMateria.Size = new Size(360, 23);
            txtBusquedaMateria.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 4;
            label1.Text = "Ingrese la materia a buscar";
            // 
            // lblMaterias
            // 
            lblMaterias.AutoSize = true;
            lblMaterias.Location = new Point(12, 74);
            lblMaterias.Name = "lblMaterias";
            lblMaterias.Size = new Size(52, 15);
            lblMaterias.TabIndex = 5;
            lblMaterias.Text = "Materias";
            // 
            // lblAlumnos
            // 
            lblAlumnos.AutoSize = true;
            lblAlumnos.Location = new Point(409, 74);
            lblAlumnos.Name = "lblAlumnos";
            lblAlumnos.Size = new Size(171, 15);
            lblAlumnos.TabIndex = 6;
            lblAlumnos.Text = "Alumnos de la materia XXXXXX";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAlumnos);
            Controls.Add(lblMaterias);
            Controls.Add(label1);
            Controls.Add(txtBusquedaMateria);
            Controls.Add(dgAlumnos);
            Controls.Add(dgMaterias);
            Controls.Add(btnBuscar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgMaterias).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private DataGridView dgMaterias;
        private DataGridView dgAlumnos;
        private TextBox txtBusquedaMateria;
        private Label label1;
        private Label lblMaterias;
        private Label lblAlumnos;
    }
}
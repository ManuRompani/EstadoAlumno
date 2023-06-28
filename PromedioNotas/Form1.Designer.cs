namespace PromedioNotas
{
    partial class ControlPromedioNotas
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
            lblNombreAlumno = new Label();
            tboxNombreAlumno = new TextBox();
            gbRegistroNotas = new GroupBox();
            tboxNota4 = new TextBox();
            lblNota1 = new Label();
            lblNota4 = new Label();
            tboxNota3 = new TextBox();
            tboxNota1 = new TextBox();
            lblNota3 = new Label();
            lblNota2 = new Label();
            tboxNota2 = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            tboxPromedioNotas = new TextBox();
            tboxNotaMasBaja = new TextBox();
            lblPromedioNotas = new Label();
            lblNotaMasBaja = new Label();
            lblCondicion = new Label();
            lblAprbadoDesaprobado = new Label();
            btnSalir = new Button();
            gbRegistroNotas.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombreAlumno
            // 
            lblNombreAlumno.AutoSize = true;
            lblNombreAlumno.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreAlumno.Location = new Point(32, 30);
            lblNombreAlumno.Name = "lblNombreAlumno";
            lblNombreAlumno.Size = new Size(61, 20);
            lblNombreAlumno.TabIndex = 0;
            lblNombreAlumno.Text = "Alumno";
            // 
            // tboxNombreAlumno
            // 
            tboxNombreAlumno.AutoCompleteMode = AutoCompleteMode.Suggest;
            tboxNombreAlumno.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tboxNombreAlumno.Location = new Point(32, 53);
            tboxNombreAlumno.Name = "tboxNombreAlumno";
            tboxNombreAlumno.Size = new Size(169, 23);
            tboxNombreAlumno.TabIndex = 1;
            // 
            // gbRegistroNotas
            // 
            gbRegistroNotas.Controls.Add(tboxNota4);
            gbRegistroNotas.Controls.Add(lblNota1);
            gbRegistroNotas.Controls.Add(lblNota4);
            gbRegistroNotas.Controls.Add(tboxNota3);
            gbRegistroNotas.Controls.Add(tboxNota1);
            gbRegistroNotas.Controls.Add(lblNota3);
            gbRegistroNotas.Controls.Add(lblNota2);
            gbRegistroNotas.Controls.Add(tboxNota2);
            gbRegistroNotas.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            gbRegistroNotas.Location = new Point(239, 26);
            gbRegistroNotas.Name = "gbRegistroNotas";
            gbRegistroNotas.Size = new Size(356, 81);
            gbRegistroNotas.TabIndex = 2;
            gbRegistroNotas.TabStop = false;
            gbRegistroNotas.Text = "Registro de notas";
            // 
            // tboxNota4
            // 
            tboxNota4.Location = new Point(265, 43);
            tboxNota4.Multiline = true;
            tboxNota4.Name = "tboxNota4";
            tboxNota4.ReadOnly = true;
            tboxNota4.Size = new Size(56, 21);
            tboxNota4.TabIndex = 2;
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNota1.Location = new Point(35, 27);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(43, 13);
            lblNota1.TabIndex = 3;
            lblNota1.Text = "NOTA1";
            // 
            // lblNota4
            // 
            lblNota4.AutoSize = true;
            lblNota4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNota4.Location = new Point(265, 27);
            lblNota4.Name = "lblNota4";
            lblNota4.Size = new Size(43, 13);
            lblNota4.TabIndex = 5;
            lblNota4.Text = "NOTA4";
            // 
            // tboxNota3
            // 
            tboxNota3.Location = new Point(189, 43);
            tboxNota3.Multiline = true;
            tboxNota3.Name = "tboxNota3";
            tboxNota3.ReadOnly = true;
            tboxNota3.Size = new Size(56, 21);
            tboxNota3.TabIndex = 3;
            // 
            // tboxNota1
            // 
            tboxNota1.Location = new Point(35, 43);
            tboxNota1.Multiline = true;
            tboxNota1.Name = "tboxNota1";
            tboxNota1.ReadOnly = true;
            tboxNota1.Size = new Size(56, 21);
            tboxNota1.TabIndex = 0;
            // 
            // lblNota3
            // 
            lblNota3.AutoSize = true;
            lblNota3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNota3.Location = new Point(189, 27);
            lblNota3.Name = "lblNota3";
            lblNota3.Size = new Size(43, 13);
            lblNota3.TabIndex = 6;
            lblNota3.Text = "NOTA3";
            // 
            // lblNota2
            // 
            lblNota2.AutoSize = true;
            lblNota2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNota2.Location = new Point(112, 27);
            lblNota2.Name = "lblNota2";
            lblNota2.Size = new Size(43, 13);
            lblNota2.TabIndex = 4;
            lblNota2.Text = "NOTA2";
            // 
            // tboxNota2
            // 
            tboxNota2.Location = new Point(112, 43);
            tboxNota2.Multiline = true;
            tboxNota2.Name = "tboxNota2";
            tboxNota2.ReadOnly = true;
            tboxNota2.Size = new Size(56, 21);
            tboxNota2.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(32, 82);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(126, 82);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // tboxPromedioNotas
            // 
            tboxPromedioNotas.Location = new Point(145, 138);
            tboxPromedioNotas.Multiline = true;
            tboxPromedioNotas.Name = "tboxPromedioNotas";
            tboxPromedioNotas.ReadOnly = true;
            tboxPromedioNotas.Size = new Size(56, 21);
            tboxPromedioNotas.TabIndex = 7;
            // 
            // tboxNotaMasBaja
            // 
            tboxNotaMasBaja.Location = new Point(145, 165);
            tboxNotaMasBaja.Multiline = true;
            tboxNotaMasBaja.Name = "tboxNotaMasBaja";
            tboxNotaMasBaja.ReadOnly = true;
            tboxNotaMasBaja.Size = new Size(56, 21);
            tboxNotaMasBaja.TabIndex = 8;
            // 
            // lblPromedioNotas
            // 
            lblPromedioNotas.AutoSize = true;
            lblPromedioNotas.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPromedioNotas.Location = new Point(18, 140);
            lblPromedioNotas.Name = "lblPromedioNotas";
            lblPromedioNotas.Size = new Size(121, 16);
            lblPromedioNotas.TabIndex = 7;
            lblPromedioNotas.Text = "Promedio de notas";
            // 
            // lblNotaMasBaja
            // 
            lblNotaMasBaja.AutoSize = true;
            lblNotaMasBaja.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNotaMasBaja.Location = new Point(44, 167);
            lblNotaMasBaja.Name = "lblNotaMasBaja";
            lblNotaMasBaja.Size = new Size(95, 16);
            lblNotaMasBaja.TabIndex = 9;
            lblNotaMasBaja.Text = "Nota mas baja";
            // 
            // lblCondicion
            // 
            lblCondicion.AutoSize = true;
            lblCondicion.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCondicion.Location = new Point(274, 143);
            lblCondicion.Name = "lblCondicion";
            lblCondicion.Size = new Size(73, 16);
            lblCondicion.TabIndex = 10;
            lblCondicion.Text = "Condicion :";
            // 
            // lblAprbadoDesaprobado
            // 
            lblAprbadoDesaprobado.AutoSize = true;
            lblAprbadoDesaprobado.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAprbadoDesaprobado.Location = new Point(347, 143);
            lblAprbadoDesaprobado.Name = "lblAprbadoDesaprobado";
            lblAprbadoDesaprobado.Size = new Size(11, 16);
            lblAprbadoDesaprobado.TabIndex = 11;
            lblAprbadoDesaprobado.Text = "-";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(521, 167);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(74, 25);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // ControlPromedioNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 209);
            Controls.Add(btnSalir);
            Controls.Add(lblAprbadoDesaprobado);
            Controls.Add(lblCondicion);
            Controls.Add(lblNotaMasBaja);
            Controls.Add(lblPromedioNotas);
            Controls.Add(tboxPromedioNotas);
            Controls.Add(tboxNotaMasBaja);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(gbRegistroNotas);
            Controls.Add(tboxNombreAlumno);
            Controls.Add(lblNombreAlumno);
            Name = "ControlPromedioNotas";
            Text = "Control de promedio de notas";
            gbRegistroNotas.ResumeLayout(false);
            gbRegistroNotas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreAlumno;
        private TextBox tboxNombreAlumno;
        private GroupBox gbRegistroNotas;
        private TextBox tboxNota3;
        private TextBox tboxNota4;
        private TextBox tboxNota2;
        private TextBox tboxNota1;
        private Label lblNota1;
        private Label lblNota2;
        private Label lblNota4;
        private Label lblNota3;
        private Button btnCalcular;
        private Button btnLimpiar;
        private TextBox tboxPromedioNotas;
        private TextBox tboxNotaMasBaja;
        private Label lblPromedioNotas;
        private Label lblNotaMasBaja;
        private Label lblCondicion;
        private Label lblAprbadoDesaprobado;
        private Button btnSalir;
    }
}
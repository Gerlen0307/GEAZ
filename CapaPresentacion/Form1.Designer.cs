namespace CapaPresentacion
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.dtgDato = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.textProvincia = new System.Windows.Forms.TextBox();
            this.textPais = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textCelular = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLIMPIAR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FECHAC = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDato)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellido";
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(825, 110);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 34);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(149, 84);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(159, 20);
            this.textNombre.TabIndex = 2;
            // 
            // dtgDato
            // 
            this.dtgDato.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dtgDato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDato.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgDato.Location = new System.Drawing.Point(362, 85);
            this.dtgDato.Name = "dtgDato";
            this.dtgDato.Size = new System.Drawing.Size(442, 320);
            this.dtgDato.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Direcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Provincia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Pais";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(61, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(59, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "Celular";
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(149, 119);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(159, 20);
            this.textApellido.TabIndex = 12;
            // 
            // textEdad
            // 
            this.textEdad.Location = new System.Drawing.Point(149, 153);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(159, 20);
            this.textEdad.TabIndex = 13;
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(149, 194);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(159, 20);
            this.textDireccion.TabIndex = 15;
            // 
            // textProvincia
            // 
            this.textProvincia.Location = new System.Drawing.Point(149, 236);
            this.textProvincia.Name = "textProvincia";
            this.textProvincia.Size = new System.Drawing.Size(159, 20);
            this.textProvincia.TabIndex = 16;
            // 
            // textPais
            // 
            this.textPais.Location = new System.Drawing.Point(149, 282);
            this.textPais.Name = "textPais";
            this.textPais.Size = new System.Drawing.Size(159, 20);
            this.textPais.TabIndex = 17;
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(149, 325);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(159, 20);
            this.textTelefono.TabIndex = 18;
            this.textTelefono.TextChanged += new System.EventHandler(this.TextTelefono_TextChanged);
            // 
            // textCelular
            // 
            this.textCelular.Location = new System.Drawing.Point(149, 363);
            this.textCelular.Name = "textCelular";
            this.textCelular.Size = new System.Drawing.Size(159, 20);
            this.textCelular.TabIndex = 19;
            this.textCelular.TextChanged += new System.EventHandler(this.TextCelular_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(446, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 31);
            this.label10.TabIndex = 20;
            this.label10.Text = "AGENDA";
            // 
            // btnLIMPIAR
            // 
            this.btnLIMPIAR.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLIMPIAR.FlatAppearance.BorderSize = 2;
            this.btnLIMPIAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLIMPIAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLIMPIAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLIMPIAR.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLIMPIAR.Location = new System.Drawing.Point(825, 185);
            this.btnLIMPIAR.Name = "btnLIMPIAR";
            this.btnLIMPIAR.Size = new System.Drawing.Size(91, 34);
            this.btnLIMPIAR.TabIndex = 21;
            this.btnLIMPIAR.Text = "LIMPIAR";
            this.btnLIMPIAR.UseVisualStyleBackColor = true;
            this.btnLIMPIAR.Click += new System.EventHandler(this.BtnLIMPIAR_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha_Nacimiento";
            // 
            // FECHAC
            // 
            this.FECHAC.Location = new System.Drawing.Point(149, 402);
            this.FECHAC.Name = "FECHAC";
            this.FECHAC.Size = new System.Drawing.Size(171, 20);
            this.FECHAC.TabIndex = 23;
            this.FECHAC.ValueChanged += new System.EventHandler(this.FECHAC_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.FECHAC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLIMPIAR);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textCelular);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.textPais);
            this.Controls.Add(this.textProvincia);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.textEdad);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgDato);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.DataGridView dtgDato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.TextBox textProvincia;
        private System.Windows.Forms.TextBox textPais;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox textCelular;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLIMPIAR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FECHAC;
    }
}


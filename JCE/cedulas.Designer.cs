
namespace JCE
{
    partial class cedulas
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
            this.btnEditCed = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNCedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSangre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpExpir = new System.Windows.Forms.DateTimePicker();
            this.cbNacionalidad = new System.Windows.Forms.ComboBox();
            this.cbOcupacion = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbColegio = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbSector = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.dgvRecords = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditCed
            // 
            this.btnEditCed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(12)))));
            this.btnEditCed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCed.FlatAppearance.BorderSize = 0;
            this.btnEditCed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(156)))), ((int)(((byte)(40)))));
            this.btnEditCed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCed.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCed.ForeColor = System.Drawing.Color.White;
            this.btnEditCed.Location = new System.Drawing.Point(1680, 553);
            this.btnEditCed.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnEditCed.Name = "btnEditCed";
            this.btnEditCed.Size = new System.Drawing.Size(301, 72);
            this.btnEditCed.TabIndex = 1;
            this.btnEditCed.Text = "Editar";
            this.btnEditCed.UseVisualStyleBackColor = false;
            this.btnEditCed.Click += new System.EventHandler(this.btnAgrCed_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(12)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1363, 553);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(301, 72);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(139, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 48);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numero de cedula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(643, -17);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 135);
            this.label1.TabIndex = 4;
            this.label1.Text = "Formulario de Cedulas";
            // 
            // txtNCedula
            // 
            this.txtNCedula.Location = new System.Drawing.Point(141, 207);
            this.txtNCedula.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtNCedula.Name = "txtNCedula";
            this.txtNCedula.Size = new System.Drawing.Size(409, 38);
            this.txtNCedula.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(139, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 48);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estado civil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(595, 274);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 48);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha de nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(1520, 386);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 48);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha Expiración";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(1053, 157);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 48);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sexo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(1059, 276);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 48);
            this.label7.TabIndex = 15;
            this.label7.Text = "Dirección";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(1061, 324);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(409, 38);
            this.txtDireccion.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(1515, 159);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 48);
            this.label8.TabIndex = 17;
            this.label8.Text = "Sangre";
            // 
            // txtSangre
            // 
            this.txtSangre.Location = new System.Drawing.Point(1523, 207);
            this.txtSangre.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtSangre.Name = "txtSangre";
            this.txtSangre.Size = new System.Drawing.Size(409, 38);
            this.txtSangre.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(1520, 279);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 48);
            this.label9.TabIndex = 19;
            this.label9.Text = "Nacionalidad";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(1061, 207);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 64);
            this.panel1.TabIndex = 20;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(219, 7);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(179, 36);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Femenino";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(8, 7);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(181, 36);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Masculino";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(603, 329);
            this.dtpNacimiento.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(409, 38);
            this.dtpNacimiento.TabIndex = 21;
            this.dtpNacimiento.ValueChanged += new System.EventHandler(this.dtpNacimiento_ValueChanged);
            // 
            // dtpExpir
            // 
            this.dtpExpir.Enabled = false;
            this.dtpExpir.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpir.Location = new System.Drawing.Point(1528, 434);
            this.dtpExpir.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dtpExpir.Name = "dtpExpir";
            this.dtpExpir.Size = new System.Drawing.Size(404, 38);
            this.dtpExpir.TabIndex = 22;
            // 
            // cbNacionalidad
            // 
            this.cbNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNacionalidad.FormattingEnabled = true;
            this.cbNacionalidad.Location = new System.Drawing.Point(1523, 324);
            this.cbNacionalidad.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbNacionalidad.Name = "cbNacionalidad";
            this.cbNacionalidad.Size = new System.Drawing.Size(409, 39);
            this.cbNacionalidad.TabIndex = 23;
            // 
            // cbOcupacion
            // 
            this.cbOcupacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOcupacion.FormattingEnabled = true;
            this.cbOcupacion.Location = new System.Drawing.Point(147, 432);
            this.cbOcupacion.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbOcupacion.Name = "cbOcupacion";
            this.cbOcupacion.Size = new System.Drawing.Size(404, 39);
            this.cbOcupacion.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkGray;
            this.label10.Location = new System.Drawing.Point(144, 386);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 48);
            this.label10.TabIndex = 24;
            this.label10.Text = "Ocupación";
            // 
            // cbColegio
            // 
            this.cbColegio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColegio.FormattingEnabled = true;
            this.cbColegio.Location = new System.Drawing.Point(608, 432);
            this.cbColegio.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbColegio.Name = "cbColegio";
            this.cbColegio.Size = new System.Drawing.Size(409, 39);
            this.cbColegio.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkGray;
            this.label11.Location = new System.Drawing.Point(605, 386);
            this.label11.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(308, 48);
            this.label11.TabIndex = 26;
            this.label11.Text = "Numero Colegio Electoral";
            // 
            // cbSector
            // 
            this.cbSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSector.FormattingEnabled = true;
            this.cbSector.Location = new System.Drawing.Point(1061, 432);
            this.cbSector.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbSector.Name = "cbSector";
            this.cbSector.Size = new System.Drawing.Size(409, 39);
            this.cbSector.TabIndex = 29;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Viudo/a",
            "Union libre"});
            this.cbEstado.Location = new System.Drawing.Point(141, 329);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(409, 39);
            this.cbEstado.TabIndex = 32;
            // 
            // dgvRecords
            // 
            this.dgvRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecords.ColumnHeadersHeight = 58;
            this.dgvRecords.Location = new System.Drawing.Point(152, 668);
            this.dgvRecords.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvRecords.Name = "dgvRecords";
            this.dgvRecords.RowHeadersWidth = 102;
            this.dgvRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecords.Size = new System.Drawing.Size(1861, 377);
            this.dgvRecords.TabIndex = 33;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(12)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(156)))), ((int)(((byte)(40)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(925, 553);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(301, 72);
            this.btnAgregar.TabIndex = 34;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkGray;
            this.label12.Location = new System.Drawing.Point(1062, 386);
            this.label12.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 48);
            this.label12.TabIndex = 28;
            this.label12.Text = "Sector";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkGray;
            this.label13.Location = new System.Drawing.Point(595, 158);
            this.label13.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 48);
            this.label13.TabIndex = 36;
            this.label13.Text = "Nombre";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(597, 207);
            this.txtNom.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(409, 38);
            this.txtNom.TabIndex = 35;
            // 
            // cedulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(27)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(2133, 1073);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvRecords);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.cbSector);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbColegio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbOcupacion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbNacionalidad);
            this.Controls.Add(this.dtpExpir);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSangre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNCedula);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditCed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "cedulas";
            this.Text = "cedulas";
            this.Load += new System.EventHandler(this.cedulas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEditCed;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSangre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.DateTimePicker dtpExpir;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox cbNacionalidad;
        private System.Windows.Forms.ComboBox cbOcupacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbColegio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbSector;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.DataGridView dgvRecords;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNom;
    }
}
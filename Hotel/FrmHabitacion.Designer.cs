namespace Hotel
{
    partial class FrmHabitacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHabitacionesDisponibles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarHabitacion = new System.Windows.Forms.Button();
            this.btnEditarHabitacion = new System.Windows.Forms.Button();
            this.btnRegistrarHabitacion = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHabitacionesNoDisponibles = new System.Windows.Forms.Button();
            this.btnListarHabitaciones = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.btnListarHabitaciones);
            this.panel1.Controls.Add(this.btnHabitacionesNoDisponibles);
            this.panel1.Controls.Add(this.btnHabitacionesDisponibles);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEliminarHabitacion);
            this.panel1.Controls.Add(this.btnEditarHabitacion);
            this.panel1.Controls.Add(this.btnRegistrarHabitacion);
            this.panel1.Location = new System.Drawing.Point(736, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 593);
            this.panel1.TabIndex = 19;
            // 
            // btnHabitacionesDisponibles
            // 
            this.btnHabitacionesDisponibles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnHabitacionesDisponibles.FlatAppearance.BorderSize = 0;
            this.btnHabitacionesDisponibles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabitacionesDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabitacionesDisponibles.ForeColor = System.Drawing.Color.White;
            this.btnHabitacionesDisponibles.Location = new System.Drawing.Point(72, 251);
            this.btnHabitacionesDisponibles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHabitacionesDisponibles.Name = "btnHabitacionesDisponibles";
            this.btnHabitacionesDisponibles.Size = new System.Drawing.Size(264, 65);
            this.btnHabitacionesDisponibles.TabIndex = 18;
            this.btnHabitacionesDisponibles.Text = "Listar habitaciones disponibles";
            this.btnHabitacionesDisponibles.UseVisualStyleBackColor = false;
            this.btnHabitacionesDisponibles.Click += new System.EventHandler(this.btnHabitacionesDisponibles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "¿Qué deseas realizar?";
            // 
            // btnEliminarHabitacion
            // 
            this.btnEliminarHabitacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnEliminarHabitacion.FlatAppearance.BorderSize = 0;
            this.btnEliminarHabitacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarHabitacion.ForeColor = System.Drawing.Color.White;
            this.btnEliminarHabitacion.Location = new System.Drawing.Point(72, 487);
            this.btnEliminarHabitacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarHabitacion.Name = "btnEliminarHabitacion";
            this.btnEliminarHabitacion.Size = new System.Drawing.Size(264, 43);
            this.btnEliminarHabitacion.TabIndex = 15;
            this.btnEliminarHabitacion.Text = "Eliminar habitación";
            this.btnEliminarHabitacion.UseVisualStyleBackColor = false;
            // 
            // btnEditarHabitacion
            // 
            this.btnEditarHabitacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnEditarHabitacion.FlatAppearance.BorderSize = 0;
            this.btnEditarHabitacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarHabitacion.ForeColor = System.Drawing.Color.White;
            this.btnEditarHabitacion.Location = new System.Drawing.Point(72, 421);
            this.btnEditarHabitacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditarHabitacion.Name = "btnEditarHabitacion";
            this.btnEditarHabitacion.Size = new System.Drawing.Size(264, 43);
            this.btnEditarHabitacion.TabIndex = 14;
            this.btnEditarHabitacion.Text = "Editar habitación";
            this.btnEditarHabitacion.UseVisualStyleBackColor = false;
            this.btnEditarHabitacion.Click += new System.EventHandler(this.btnEditarHabitacion_Click);
            // 
            // btnRegistrarHabitacion
            // 
            this.btnRegistrarHabitacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnRegistrarHabitacion.FlatAppearance.BorderSize = 0;
            this.btnRegistrarHabitacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarHabitacion.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarHabitacion.Location = new System.Drawing.Point(72, 118);
            this.btnRegistrarHabitacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrarHabitacion.Name = "btnRegistrarHabitacion";
            this.btnRegistrarHabitacion.Size = new System.Drawing.Size(264, 47);
            this.btnRegistrarHabitacion.TabIndex = 12;
            this.btnRegistrarHabitacion.Text = "Registrar habitación";
            this.btnRegistrarHabitacion.UseVisualStyleBackColor = false;
            this.btnRegistrarHabitacion.Click += new System.EventHandler(this.btnRegistrarHabitacion_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeight = 30;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.dataGridView1.Location = new System.Drawing.Point(31, 110);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.Size = new System.Drawing.Size(675, 438);
            this.dataGridView1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Habitaciones";
            // 
            // btnHabitacionesNoDisponibles
            // 
            this.btnHabitacionesNoDisponibles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnHabitacionesNoDisponibles.FlatAppearance.BorderSize = 0;
            this.btnHabitacionesNoDisponibles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabitacionesNoDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabitacionesNoDisponibles.ForeColor = System.Drawing.Color.White;
            this.btnHabitacionesNoDisponibles.Location = new System.Drawing.Point(72, 335);
            this.btnHabitacionesNoDisponibles.Margin = new System.Windows.Forms.Padding(4);
            this.btnHabitacionesNoDisponibles.Name = "btnHabitacionesNoDisponibles";
            this.btnHabitacionesNoDisponibles.Size = new System.Drawing.Size(264, 65);
            this.btnHabitacionesNoDisponibles.TabIndex = 19;
            this.btnHabitacionesNoDisponibles.Text = "Listar habitaciones no disponibles";
            this.btnHabitacionesNoDisponibles.UseVisualStyleBackColor = false;
            this.btnHabitacionesNoDisponibles.Click += new System.EventHandler(this.btnHabitacionesNoDisponibles_Click);
            // 
            // btnListarHabitaciones
            // 
            this.btnListarHabitaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnListarHabitaciones.FlatAppearance.BorderSize = 0;
            this.btnListarHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarHabitaciones.ForeColor = System.Drawing.Color.White;
            this.btnListarHabitaciones.Location = new System.Drawing.Point(72, 183);
            this.btnListarHabitaciones.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarHabitaciones.Name = "btnListarHabitaciones";
            this.btnListarHabitaciones.Size = new System.Drawing.Size(264, 47);
            this.btnListarHabitaciones.TabIndex = 20;
            this.btnListarHabitaciones.Text = "Listar habitaciones";
            this.btnListarHabitaciones.UseVisualStyleBackColor = false;
            this.btnListarHabitaciones.Click += new System.EventHandler(this.btnListarHabitaciones_Click);
            // 
            // FrmHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1123, 589);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmHabitacion";
            this.Text = "FrmHabitacion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarHabitacion;
        private System.Windows.Forms.Button btnEditarHabitacion;
        private System.Windows.Forms.Button btnRegistrarHabitacion;
        private System.Windows.Forms.Button btnHabitacionesDisponibles;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListarHabitaciones;
        private System.Windows.Forms.Button btnHabitacionesNoDisponibles;
    }
}
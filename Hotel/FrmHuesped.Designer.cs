namespace Hotel
{
    partial class FrmHuesped
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRegistrarHuesped = new System.Windows.Forms.Button();
            this.btnEditarHuesped = new System.Windows.Forms.Button();
            this.btnEliminarHuesped = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvHuespedes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListarHuespes = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuespedes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrarHuesped
            // 
            this.btnRegistrarHuesped.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnRegistrarHuesped.FlatAppearance.BorderSize = 0;
            this.btnRegistrarHuesped.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarHuesped.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarHuesped.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarHuesped.Location = new System.Drawing.Point(66, 148);
            this.btnRegistrarHuesped.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarHuesped.Name = "btnRegistrarHuesped";
            this.btnRegistrarHuesped.Size = new System.Drawing.Size(264, 47);
            this.btnRegistrarHuesped.TabIndex = 12;
            this.btnRegistrarHuesped.Text = "Registrar huésped";
            this.btnRegistrarHuesped.UseVisualStyleBackColor = false;
            this.btnRegistrarHuesped.Click += new System.EventHandler(this.btnRegistrarHuesped_Click);
            // 
            // btnEditarHuesped
            // 
            this.btnEditarHuesped.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnEditarHuesped.FlatAppearance.BorderSize = 0;
            this.btnEditarHuesped.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarHuesped.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarHuesped.ForeColor = System.Drawing.Color.White;
            this.btnEditarHuesped.Location = new System.Drawing.Point(66, 308);
            this.btnEditarHuesped.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarHuesped.Name = "btnEditarHuesped";
            this.btnEditarHuesped.Size = new System.Drawing.Size(264, 43);
            this.btnEditarHuesped.TabIndex = 14;
            this.btnEditarHuesped.Text = "Editar huésped";
            this.btnEditarHuesped.UseVisualStyleBackColor = false;
            // 
            // btnEliminarHuesped
            // 
            this.btnEliminarHuesped.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnEliminarHuesped.FlatAppearance.BorderSize = 0;
            this.btnEliminarHuesped.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarHuesped.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarHuesped.ForeColor = System.Drawing.Color.White;
            this.btnEliminarHuesped.Location = new System.Drawing.Point(66, 382);
            this.btnEliminarHuesped.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarHuesped.Name = "btnEliminarHuesped";
            this.btnEliminarHuesped.Size = new System.Drawing.Size(264, 43);
            this.btnEliminarHuesped.TabIndex = 15;
            this.btnEliminarHuesped.Text = "Eliminar huésped";
            this.btnEliminarHuesped.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "¿Qué deseas realizar?";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.btnListarHuespes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEliminarHuesped);
            this.panel1.Controls.Add(this.btnEditarHuesped);
            this.panel1.Controls.Add(this.btnRegistrarHuesped);
            this.panel1.Location = new System.Drawing.Point(746, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 553);
            this.panel1.TabIndex = 18;
            // 
            // dgvHuespedes
            // 
            this.dgvHuespedes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHuespedes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHuespedes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.dgvHuespedes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHuespedes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHuespedes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHuespedes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHuespedes.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHuespedes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHuespedes.EnableHeadersVisualStyles = false;
            this.dgvHuespedes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.dgvHuespedes.Location = new System.Drawing.Point(29, 112);
            this.dgvHuespedes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHuespedes.Name = "dgvHuespedes";
            this.dgvHuespedes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHuespedes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHuespedes.Size = new System.Drawing.Size(693, 405);
            this.dgvHuespedes.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Huéspedes ";
            // 
            // btnListarHuespes
            // 
            this.btnListarHuespes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnListarHuespes.FlatAppearance.BorderSize = 0;
            this.btnListarHuespes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarHuespes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarHuespes.ForeColor = System.Drawing.Color.White;
            this.btnListarHuespes.Location = new System.Drawing.Point(66, 231);
            this.btnListarHuespes.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarHuespes.Name = "btnListarHuespes";
            this.btnListarHuespes.Size = new System.Drawing.Size(264, 47);
            this.btnListarHuespes.TabIndex = 18;
            this.btnListarHuespes.Text = "Listar huéspedes";
            this.btnListarHuespes.UseVisualStyleBackColor = false;
            this.btnListarHuespes.Click += new System.EventHandler(this.btnListarHuespes_Click);
            // 
            // FrmHuesped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1123, 549);
            this.Controls.Add(this.dgvHuespedes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "FrmHuesped";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHuesped";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuespedes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarHuesped;
        private System.Windows.Forms.Button btnEditarHuesped;
        private System.Windows.Forms.Button btnEliminarHuesped;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvHuespedes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListarHuespes;
    }
}
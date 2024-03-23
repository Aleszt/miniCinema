
namespace miniCinema
{
    partial class Peliculas
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.lbl_año = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_año = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.dgv_peliculas = new System.Windows.Forms.DataGridView();
            this.identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.lbl_Peliculas = new System.Windows.Forms.Label();
            this.cb_genero = new System.Windows.Forms.ComboBox();
            this.btn_cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_peliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_nombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_nombre.Location = new System.Drawing.Point(97, 125);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(68, 18);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_genero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_genero.Location = new System.Drawing.Point(97, 182);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(65, 18);
            this.lbl_genero.TabIndex = 1;
            this.lbl_genero.Text = "Genero";
            // 
            // lbl_año
            // 
            this.lbl_año.AutoSize = true;
            this.lbl_año.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_año.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_año.Location = new System.Drawing.Point(97, 245);
            this.lbl_año.Name = "lbl_año";
            this.lbl_año.Size = new System.Drawing.Size(96, 18);
            this.lbl_año.TabIndex = 2;
            this.lbl_año.Text = "Año estreno";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_descripcion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_descripcion.Location = new System.Drawing.Point(97, 310);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(97, 18);
            this.lbl_descripcion.TabIndex = 3;
            this.lbl_descripcion.Text = "Descripción";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(228, 123);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(202, 20);
            this.txt_name.TabIndex = 4;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // txt_año
            // 
            this.txt_año.Location = new System.Drawing.Point(228, 246);
            this.txt_año.Name = "txt_año";
            this.txt_año.Size = new System.Drawing.Size(202, 20);
            this.txt_año.TabIndex = 6;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(228, 311);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(202, 20);
            this.txt_descripcion.TabIndex = 7;
            // 
            // dgv_peliculas
            // 
            this.dgv_peliculas.AllowUserToAddRows = false;
            this.dgv_peliculas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_peliculas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_peliculas.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_peliculas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_peliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_peliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identificador,
            this.Nombre,
            this.Genero,
            this.Fecha,
            this.descripcion});
            this.dgv_peliculas.Location = new System.Drawing.Point(493, 113);
            this.dgv_peliculas.Name = "dgv_peliculas";
            this.dgv_peliculas.RowHeadersVisible = false;
            this.dgv_peliculas.Size = new System.Drawing.Size(395, 340);
            this.dgv_peliculas.TabIndex = 8;
            this.dgv_peliculas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // identificador
            // 
            this.identificador.HeaderText = "identificador";
            this.identificador.Name = "identificador";
            this.identificador.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_save.Location = new System.Drawing.Point(90, 408);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_clear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_clear.Location = new System.Drawing.Point(210, 408);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "Limpiar";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_update
            // 
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_update.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_update.Location = new System.Drawing.Point(334, 408);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(96, 23);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "Actualizar";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lbl_Peliculas
            // 
            this.lbl_Peliculas.AutoSize = true;
            this.lbl_Peliculas.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Peliculas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Peliculas.Location = new System.Drawing.Point(394, 33);
            this.lbl_Peliculas.Name = "lbl_Peliculas";
            this.lbl_Peliculas.Size = new System.Drawing.Size(139, 36);
            this.lbl_Peliculas.TabIndex = 12;
            this.lbl_Peliculas.Text = "Peliculas";
            // 
            // cb_genero
            // 
            this.cb_genero.FormattingEnabled = true;
            this.cb_genero.Items.AddRange(new object[] {
            "Terror",
            "Romance",
            "Animado",
            "Thriller",
            "Cómica"});
            this.cb_genero.Location = new System.Drawing.Point(228, 182);
            this.cb_genero.Name = "cb_genero";
            this.cb_genero.Size = new System.Drawing.Size(202, 21);
            this.cb_genero.TabIndex = 13;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_cerrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_cerrar.Location = new System.Drawing.Point(210, 454);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 14;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Peliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(924, 602);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.cb_genero);
            this.Controls.Add(this.lbl_Peliculas);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dgv_peliculas);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_año);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.lbl_año);
            this.Controls.Add(this.lbl_genero);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "Peliculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peliculas";
            this.Load += new System.EventHandler(this.Peliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_peliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.Label lbl_año;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_año;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.DataGridView dgv_peliculas;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label lbl_Peliculas;
        private System.Windows.Forms.ComboBox cb_genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.Button btn_cerrar;
    }
}
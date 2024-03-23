
namespace miniCinema
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_rentar = new System.Windows.Forms.Button();
            this.btn_peliculas = new System.Windows.Forms.Button();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_cine1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Regresar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cine1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btn_rentar);
            this.panel1.Controls.Add(this.btn_peliculas);
            this.panel1.Controls.Add(this.btn_clientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 81);
            this.panel1.TabIndex = 0;
            // 
            // btn_rentar
            // 
            this.btn_rentar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_rentar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_rentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rentar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_rentar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_rentar.Location = new System.Drawing.Point(652, 22);
            this.btn_rentar.Name = "btn_rentar";
            this.btn_rentar.Size = new System.Drawing.Size(90, 37);
            this.btn_rentar.TabIndex = 2;
            this.btn_rentar.Text = "Rentar";
            this.btn_rentar.UseVisualStyleBackColor = false;
            this.btn_rentar.Click += new System.EventHandler(this.btn_rentar_Click);
            // 
            // btn_peliculas
            // 
            this.btn_peliculas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_peliculas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_peliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_peliculas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_peliculas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_peliculas.Location = new System.Drawing.Point(376, 22);
            this.btn_peliculas.Name = "btn_peliculas";
            this.btn_peliculas.Size = new System.Drawing.Size(90, 37);
            this.btn_peliculas.TabIndex = 1;
            this.btn_peliculas.Text = "Peliculas";
            this.btn_peliculas.UseVisualStyleBackColor = false;
            this.btn_peliculas.Click += new System.EventHandler(this.btn_peliculas_Click);
            // 
            // btn_clientes
            // 
            this.btn_clientes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_clientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_clientes.Location = new System.Drawing.Point(92, 22);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(96, 37);
            this.btn_clientes.TabIndex = 0;
            this.btn_clientes.Text = "Clientes";
            this.btn_clientes.UseVisualStyleBackColor = false;
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 212);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dgv_cine1
            // 
            this.dgv_cine1.AllowUserToAddRows = false;
            this.dgv_cine1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cine1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_cine1.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_cine1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_cine1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cine1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Cliente,
            this.Pelicula,
            this.Fecha,
            this.Regresar});
            this.dgv_cine1.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgv_cine1.Location = new System.Drawing.Point(310, 118);
            this.dgv_cine1.Name = "dgv_cine1";
            this.dgv_cine1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_cine1.RowHeadersVisible = false;
            this.dgv_cine1.Size = new System.Drawing.Size(493, 375);
            this.dgv_cine1.TabIndex = 2;
            this.dgv_cine1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cine1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Pelicula
            // 
            this.Pelicula.HeaderText = "Pelicula";
            this.Pelicula.Name = "Pelicula";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Regresar
            // 
            this.Regresar.HeaderText = "Regresar";
            this.Regresar.Image = ((System.Drawing.Image)(resources.GetObject("Regresar.Image")));
            this.Regresar.Name = "Regresar";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(728, 496);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 3;
            this.btn_refresh.Text = "Recargar";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 523);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.dgv_cine1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cine1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_rentar;
        private System.Windows.Forms.Button btn_peliculas;
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_cine1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewImageColumn Regresar;
        private System.Windows.Forms.Button btn_refresh;
    }
}



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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.btn_peliculas = new System.Windows.Forms.Button();
            this.btn_rentar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 212);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView1.Location = new System.Drawing.Point(310, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.Size = new System.Drawing.Size(493, 375);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 523);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_rentar;
        private System.Windows.Forms.Button btn_peliculas;
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


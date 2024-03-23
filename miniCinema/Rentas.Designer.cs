
namespace miniCinema
{
    partial class Rentas
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
            this.btn_rentar = new System.Windows.Forms.Button();
            this.dt_fecha = new System.Windows.Forms.DateTimePicker();
            this.cb_pelicula = new System.Windows.Forms.ComboBox();
            this.cb_usuario = new System.Windows.Forms.ComboBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_rentar
            // 
            this.btn_rentar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_rentar.Location = new System.Drawing.Point(318, 345);
            this.btn_rentar.Name = "btn_rentar";
            this.btn_rentar.Size = new System.Drawing.Size(75, 28);
            this.btn_rentar.TabIndex = 0;
            this.btn_rentar.Text = "Rentar";
            this.btn_rentar.UseVisualStyleBackColor = true;
            this.btn_rentar.Click += new System.EventHandler(this.btn_rentar_Click);
            // 
            // dt_fecha
            // 
            this.dt_fecha.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dt_fecha.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dt_fecha.Location = new System.Drawing.Point(375, 255);
            this.dt_fecha.Name = "dt_fecha";
            this.dt_fecha.Size = new System.Drawing.Size(223, 21);
            this.dt_fecha.TabIndex = 1;
            // 
            // cb_pelicula
            // 
            this.cb_pelicula.FormattingEnabled = true;
            this.cb_pelicula.Location = new System.Drawing.Point(375, 190);
            this.cb_pelicula.Name = "cb_pelicula";
            this.cb_pelicula.Size = new System.Drawing.Size(223, 21);
            this.cb_pelicula.TabIndex = 2;
            // 
            // cb_usuario
            // 
            this.cb_usuario.FormattingEnabled = true;
            this.cb_usuario.Location = new System.Drawing.Point(375, 124);
            this.cb_usuario.Name = "cb_usuario";
            this.cb_usuario.Size = new System.Drawing.Size(223, 21);
            this.cb_usuario.TabIndex = 3;
            this.cb_usuario.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_usuario.Location = new System.Drawing.Point(287, 124);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(62, 18);
            this.lbl_usuario.TabIndex = 4;
            this.lbl_usuario.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(287, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Película";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(287, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha";
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_close.Location = new System.Drawing.Point(426, 345);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 28);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "Cerrar";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Rentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.cb_usuario);
            this.Controls.Add(this.cb_pelicula);
            this.Controls.Add(this.dt_fecha);
            this.Controls.Add(this.btn_rentar);
            this.Name = "Rentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rentas";
            this.Load += new System.EventHandler(this.Rentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_rentar;
        private System.Windows.Forms.DateTimePicker dt_fecha;
        private System.Windows.Forms.ComboBox cb_pelicula;
        private System.Windows.Forms.ComboBox cb_usuario;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_close;
    }
}
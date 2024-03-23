using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniCinema
{
    public partial class Peliculas : Form
    {
        Conexion cn = new Conexion();
        string id = "";
        public Peliculas()
        {
            InitializeComponent();
        }
        
        
        private void cargar_datos_tabla()
        {
            dgv_peliculas.Rows.Clear();
            DataTable datos = cn.CargarDatos("SELECT * FROM `peliculas`");
            foreach (DataRow fila in datos.Rows)
            {

                dgv_peliculas.Rows.Add(fila["id"].ToString(), fila["nombre"].ToString(), fila["genero"].ToString(), fila["estreno"].ToString(), fila["descripcion"].ToString());
            }
        }

        private void Peliculas_Load(object sender, EventArgs e)
        {
            cb_genero.SelectedIndex = 0;
            cargar_datos_tabla();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_año.Clear();
            txt_descripcion.Clear();
            txt_name.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgv_peliculas.Rows[e.RowIndex];
            txt_name.Text = selectedRow.Cells["nombre"].Value.ToString();
            cb_genero.Text = selectedRow.Cells["genero"].Value.ToString();
            txt_año.Text = selectedRow.Cells["año"].Value.ToString();
            txt_descripcion.Text = selectedRow.Cells["descripcion"].Value.ToString();
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgv_peliculas.Rows[e.RowIndex];
            id = selectedRow.Cells["identificador"].Value.ToString();
            txt_name.Text = selectedRow.Cells["nombre"].Value.ToString();
            cb_genero.Text = selectedRow.Cells["genero"].Value.ToString();
            txt_año.Text = selectedRow.Cells["fecha"].Value.ToString();
            txt_descripcion.Text = selectedRow.Cells["descripcion"].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            cn.EjecutarConsulta($"UPDATE peliculas SET nombre = '{txt_name.Text}', genero = '{cb_genero.Text}', estreno = '{txt_año.Text}', descripcion = '{txt_descripcion.Text}' WHERE ID = {id}");
            cargar_datos_tabla();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string nombre = txt_name.Text.ToString();
            string genero = cb_genero.Text.ToString();
            string añoStr = txt_año.Text;
            string descripcion = txt_descripcion.Text.ToString();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(genero) || string.IsNullOrWhiteSpace(añoStr) || string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("No dejar espacios en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int año;
            if (!int.TryParse(añoStr, out año) || año <= 0)
            {
                MessageBox.Show("Por favor, ingrese un año válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cn.EjecutarConsulta($"INSERT INTO peliculas (Nombre, Genero, Estreno, Descripcion) VALUES ('{nombre}', '{genero}', {añoStr}, '{descripcion}')");
            MessageBox.Show("Datos guardados exitosamente", "¡Bien!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cargar_datos_tabla();
            txt_año.Clear(); txt_descripcion.Clear(); txt_name.Clear();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

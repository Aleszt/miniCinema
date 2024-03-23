using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniCinema
{
    public partial class Registro : Form
    {
        Conexion cn = new Conexion();
        string id = "";
        public Registro()
        {
            InitializeComponent();
        }
        private void cargar_datos_tabla()
        {
            dgv_datos.Rows.Clear();
            DataTable datos = cn.CargarDatos("SELECT * FROM `registro`");
            foreach (DataRow fila in datos.Rows)
            {

                dgv_datos.Rows.Add(fila["id"].ToString(), fila["nombre"].ToString(), fila["apellido"].ToString(), fila["telefono"].ToString(), fila["correo"].ToString());
            }
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            cargar_datos_tabla();
        }

        private void dgv_datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgv_datos.Rows[e.RowIndex];
            id = selectedRow.Cells["identificador"].Value.ToString();
            txt_name.Text = selectedRow.Cells["nombre"].Value.ToString();
            txt_apellido.Text = selectedRow.Cells["apellido"].Value.ToString();
            txt_telefono.Text = selectedRow.Cells["telefono"].Value.ToString();
            txt_email.Text = selectedRow.Cells["correo"].Value.ToString();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string nombre = txt_name.Text.ToString();
            string apellido = txt_apellido.Text.ToString();
            string telefono = txt_telefono.Text;
            string email = txt_email.Text.ToString();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(telefono) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("No dejar espacios en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            cn.EjecutarConsulta($"INSERT INTO registro (Nombre, Apellido, Telefono, Correo) VALUES ('{nombre}', '{apellido}', {telefono}, '{email}')");
            MessageBox.Show("Datos guardados exitosamente", "¡Bien!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cargar_datos_tabla();
            txt_name.Clear(); txt_apellido.Clear(); txt_telefono.Clear(); txt_email.Clear();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_name.Clear();
            txt_apellido.Clear();
            txt_telefono.Clear();
            txt_email.Clear();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            cn.EjecutarConsulta($"UPDATE registro SET nombre = '{txt_name.Text}', apellido = '{txt_apellido.Text}', telefono = '{txt_telefono.Text}', correo = '{txt_email.Text}' WHERE ID = {id}");
            cargar_datos_tabla();
            txt_name.Clear(); txt_apellido.Clear(); txt_telefono.Clear(); txt_email.Clear();
        }
    }
}

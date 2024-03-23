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
    public partial class Rentas : Form
    {
        Conexion cn = new Conexion();
        string id = "";
        private int id_cliente = -1;
        private int id_pelicula = -1;
        public Rentas()
        {
            InitializeComponent();
        }

        private void cargar_datos_tabla()
        {
            cb_usuario.Items.Clear();
            DataTable datos = cn.CargarDatos("SELECT id, nombre FROM `registro`");
            foreach (DataRow fila in datos.Rows)
            {
                string item = fila["id"].ToString() + ". " + fila["nombre"].ToString();
                cb_usuario.Items.Add(item);
                
            }
        }


        private void cargar_datos_tabla_2()
        {
            cb_pelicula.Items.Clear();
            DataTable dato = cn.CargarDatos("SELECT id, nombre FROM `peliculas`");
            foreach (DataRow fila in dato.Rows)
            {
                string item = fila["id"].ToString() + ". " + fila["nombre"].ToString();
                cb_pelicula.Items.Add(item);
            }
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Rentas_Load(object sender, EventArgs e)
        {
            cargar_datos_tabla();
            cargar_datos_tabla_2();
        }

        private void btn_rentar_Click(object sender, EventArgs e)
        {
            
            
            if (cb_usuario.SelectedIndex != -1 && cb_pelicula.SelectedIndex != -1)
            {
                string[] partesUsuario = cb_usuario.SelectedItem.ToString().Split('.');
                id_cliente = int.Parse(partesUsuario[0]);

                string[] partesPelicula = cb_pelicula.SelectedItem.ToString().Split('.');
                id_pelicula = int.Parse(partesPelicula[0]);

                MessageBox.Show($"ID del cliente seleccionado: {id_cliente}\nID de la película seleccionada: {id_pelicula}");
                DateTime dt_fecha = DateTime.Now;

                cn.EjecutarConsulta($"INSERT INTO rentas (idcliente, idpelicula, fechaoperacion, estatus) VALUES ({id_cliente}, {id_pelicula}, '{dt_fecha.ToString("yyyy-MM-dd HH:mm:ss")}', {1})");
            }
            else if (cb_usuario.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un cliente primero.");
            }
            else if (cb_pelicula.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione una película primero.");
            }

            Form1 form = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (form != null)
            {
                form.cargar_datos_tabla(); 
            }

            this.Close();
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

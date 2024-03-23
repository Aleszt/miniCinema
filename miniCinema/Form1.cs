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
    public partial class Form1 : Form
    {
        string idcliente = "";
        Conexion cn = new Conexion();
        private void Form1_Load(object sender, EventArgs e)
        {
            cargar_datos_tabla();
            
            

        }
        public void cargar_datos_tabla()
        {
            dgv_cine1.Rows.Clear();
            DataTable datos = cn.CargarDatos("SELECT registro.id, registro.nombre, peliculas.id, peliculas.nombre, rentas.fechaoperacion, rentas.estatus, rentas.id FROM rentas INNER JOIN registro ON rentas.idcliente = registro.id INNER JOIN peliculas ON rentas.idcliente = peliculas.id WHERE rentas.estatus = 1");
            foreach (DataRow fila in datos.Rows)
            {
                dgv_cine1.Rows.Add(fila["id2"], fila["nombre"].ToString(), fila["nombre1"].ToString(), fila["fechaoperacion"].ToString());
                //id2 es el que ocuparia
                var identificador = fila["id2"];
            }
        }
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btn_clientes_Click(object sender, EventArgs e)
        {
            Registro registroForm = new Registro();
            registroForm.ShowDialog();
        }

        private void btn_peliculas_Click(object sender, EventArgs e)
        {
            Peliculas peliculasForm = new Peliculas();
            peliculasForm.ShowDialog();
        }

        private void btn_rentar_Click(object sender, EventArgs e)
        {
            Rentas rentasForm = new Rentas();
            rentasForm.ShowDialog();
        }

        private void dgv_cine1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgv_cine1.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                
                if (dgv_cine1.Columns[e.ColumnIndex].Name == "Regresar")
                {
                    var id2 = dgv_cine1.Rows[e.RowIndex].Cells["ID"].Value;
                    
                    DialogResult result = MessageBox.Show("¿Está seguro de que desea continuar?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        if (id2 != null && id2 != DBNull.Value)
                        {
                            int id2Value = Convert.ToInt32(id2);
                            cn.EjecutarConsulta($"UPDATE rentas SET estatus = 0 WHERE ID = {id2}");
                            dgv_cine1.Rows.RemoveAt(e.RowIndex);
                            dgv_cine1.Refresh();
                        }
                    }
                    else
                    {
                           
                    }
                }

            }
            
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            cargar_datos_tabla();
        }
    }
    /*.....*/
}

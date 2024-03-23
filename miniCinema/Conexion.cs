using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using System.Data;
using System.Threading.Tasks;


namespace miniCinema
{
    class Conexion
    {
        private MySqlConnection sql_con;
        private MySqlCommand sql_cmd;
        private MySqlDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        // pasamos variables entre la calse de conexion con la de consultas
        public static MySqlConnection cs_sql_con;
        public static MySqlCommand cs_sql_cmd;
        public static MySqlDataAdapter cs_DB;
        public static DataSet cs_DS = new DataSet();
        public static DataTable cs_DT = new DataTable();

        [DllImport("wininet.dll")]
        public extern static bool InternetGetConnectedState(out int Descripcion, int ValorReservado);

        public static bool ConectadoInternet()
        {
            int Desc;
            return InternetGetConnectedState(out Desc, 0);
        }

        public Conexion()
        {
            cs_sql_con = sql_con;
            cs_sql_cmd = sql_cmd;
            cs_DB = DB;
            cs_DS = DS;
            cs_DT = DT;
        }
        public void Conectarse(bool ignorar = false)
        {

            if (ignorar == true)
            {
                sql_con = new MySqlConnection("datasource=127.0.0.1;port=6666;username=root;password=;database=cine;");
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.Hosting))
                {
                    sql_con = new MySqlConnection("datasource=" + Properties.Settings.Default.Hosting + ";port=6666;username=root;password=;database=cine;");
                }
                else
                {
                    sql_con = new MySqlConnection("datasource=127.0.0.1;port=6666;username=root;password=;database=cine;");
                }
            }
        }
        public int EjecutarConsulta(string consulta, bool ignorar = false, bool regresarID = false)
        {
            int resultado = 0;
            Conectarse(ignorar);
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = consulta;
            resultado = sql_cmd.ExecuteNonQuery();
            sql_con.Close();

            if (regresarID)
            {
                resultado = Convert.ToInt32(sql_cmd.LastInsertedId);
            }

            return resultado;
        }
        public DataTable CargarDatos(string consulta)
        {
            DataTable db = new DataTable();
            Conectarse();
            sql_con.Open();
            MySqlCommand com = new MySqlCommand(consulta, sql_con);
            MySqlDataAdapter adap = new MySqlDataAdapter(com);
            adap.Fill(db);
            sql_con.Close();
            return db;
        }
    }
}

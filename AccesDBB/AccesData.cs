using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace AccesDBB
{
    public class AccesData
    {
        public string ConnString { get; set; }

        public AccesData()
        {
            ConnectionStringSettings conf = ConfigurationManager.ConnectionStrings["DarkCore"];
            ConnString = conf.ConnectionString;

            EncryptConfigFile();
        }

        private SqlConnection CrearConexion()
        {
            SqlConnection conexion = new SqlConnection(ConnString);
            conexion.Open();
            return conexion;
        }


        public DataSet PortaTaula(string taula)
        {
            using (SqlConnection conexion  = CrearConexion())
            {
                DataSet dts = new DataSet();
                string query = $"select * from {taula}";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                adapter.Fill(dts, taula);
                return dts;
            }
        }

        public string PerformLogin(string codeUser)
        {
            DataRow[] rowsFound;
            string descUser, edadUser, planetaUser;

            DataSet dts = PortaTaula("Users");
            rowsFound = dts.Tables[0].Select($"codeUser = '{codeUser}'");

            if (rowsFound.Length > 0)
            {
                descUser = rowsFound[0].Field<string>("descUser");
                edadUser = rowsFound[0].Field<string>("edad");
                planetaUser = rowsFound[0].Field<string>("planeta");
            }
            else
            {
                return null;
            }

            return descUser;
        }

        public void Actualitzar(string tableName, string codeUser, string columnName, object newValue)
        {
            try
            {
                string selectQuery = $"SELECT * FROM {tableName} WHERE codeUser = '{codeUser}'";

                using (SqlConnection conexion = CrearConexion())
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, conexion);

                    DataSet dts = new DataSet();
                    adapter.Fill(dts);

                    if (dts.Tables[0].Rows.Count > 0)
                    {
                        DataRow row = dts.Tables[0].Rows[0];
                        row[columnName] = newValue;

                        SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);

                        int result = adapter.Update(dts.Tables[0]);
                    }
                    else
                    {
                        MessageBox.Show($"No se encontró ningún registro con codeUser '{codeUser}'.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la base de datos: {ex.Message}");
            }
        }

        public void EncryptConfigFile()
        {
            Configuration conf = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            ConnectionStringsSection section = conf.GetSection("connectionStrings") as ConnectionStringsSection;

            if (!section.SectionInformation.IsProtected)
            {
                section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                conf.Save();
            }
        }
    }
}

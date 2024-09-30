using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //INICIAR LA CONEXION CON BD
        SqlConnection conn = new SqlConnection("Data Source=L-L-L\\SQLEXPRESS;Initial Catalog=BD_Sistema;Integrated Security=True;");

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
            
                SqlCommand comando = new SqlCommand("select Usuario,Contraseña from persona where Usuario = @vusuario and Contraseña = @vcontrasena;", conn);
                comando.Parameters.AddWithValue("@vusuario",txt_usuario.Text);
                comando.Parameters.AddWithValue("@vcontrasena", txt_contrasena.Text);
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    conn.Close();
                    Home pantalla= new Home();
                    pantalla.Show();
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
            catch (Exception ex) 
            {
                conn.Close();
                MessageBox.Show($"Error {ex.Message}");
            }
        }
    }
}

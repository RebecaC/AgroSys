using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Collections;
using System.Linq;
using System.Security.Cryptography;

namespace AgroSys
{
    public partial class IngresoUsuarios : Telerik.WinControls.UI.RadForm
    {
        public IngresoUsuarios()
        {
            InitializeComponent();
        }

        private void IngresoUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'agrosysDataSet.rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter1.Fill(this.agrosysDataSet.rol);
            // TODO: esta línea de código carga datos en la tabla 'agrosysDataSet6.empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter1.Fill(this.agrosysDataSet6.empleado);
        

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        public void SaveUsuarios()
        {
            try
            {

                var nombre = txtUsuario.Text.ToString();
                var password = txtPassword.Text.ToString();
                var rolID = Convert.ToInt16(ddlRol.SelectedValue.ToString());
                var empleadoID = Convert.ToInt16(ddlEmpleado.SelectedValue.ToString());
                SetUsuarios(nombre, password, rolID, empleadoID);

            }
            catch (Exception)
            {
                throw new Exception("Hay un problema al guardar el Producto, por favor intente de nuevo.");
            }

        }
        public void SetUsuarios(string nombre, string password, int rolID, int empleadoID)
        {
            try
            {
                usuario objTiendaVerificar = new usuario();
                using (agrosysEntitiesFull VerificarTiendaEntidad = new agrosysEntitiesFull())
                {
                    objTiendaVerificar = VerificarTiendaEntidad.usuarios.Where(s => s.nombre_usuario == nombre).FirstOrDefault<usuario>();
                }

                if (objTiendaVerificar == null)
                {

                    using (agrosysEntitiesFull TiendaEntidad = new agrosysEntitiesFull())
                    {
                        usuario objusuarios = new usuario();
                        string md5Password;
                        
                        using (MD5 md5Hash = MD5.Create())
                        {
                           md5Password= GetMd5Hash(md5Hash, password);
                        }
                        objusuarios.nombre_usuario = nombre;
                        objusuarios.password = md5Password;
                        objusuarios.rol_id_rol = rolID;
                        objusuarios.empleado_id_empleado = empleadoID;

                        TiendaEntidad.usuarios.Add(objusuarios);
                        TiendaEntidad.SaveChanges();
                        string mensaje = "El usuaris con el Nombre " + nombre + " a sido guardado";
                        ShowNotification(mensaje);
                    }
                }
                else
                {
                    ShowNotification("No se a podido guardar el registro");
                }

            }
            catch (Exception)
            {
                throw new Exception("Hay un problema al guardar la tienda, por favor intente de nuevo.");
            }

        }

        public void ShowNotification(string messaje)
        {
            MessageBox.Show(messaje.ToString());
        }
        public void LimpiarCampos() 
        {
            txtPassword.Text = "";
            txtUsuario.Text = "";
        }
        private void radButton1_Click(object sender, EventArgs e)
        {
            SaveUsuarios();
        }

      
            static string GetMd5Hash(MD5 md5Hash, string input)
            {

                // Convert the input string to a byte array and compute the hash. 
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Create a new Stringbuilder to collect the bytes 
                // and create a string.
                StringBuilder sBuilder = new StringBuilder();

                // Loop through each byte of the hashed data  
                // and format each one as a hexadecimal string. 
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                // Return the hexadecimal string. 
                return sBuilder.ToString();
            }

            // Verify a hash against a string. 
            static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
            {
                // Hash the input. 
                string hashOfInput = GetMd5Hash(md5Hash, input);

                // Create a StringComparer an compare the hashes.
                StringComparer comparer = StringComparer.OrdinalIgnoreCase;

                if (0 == comparer.Compare(hashOfInput, hash))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        
    }
}

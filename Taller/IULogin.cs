using LNegocioyADatos;
using LNegocioyADatos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller
{
    public partial class IULogin : Form
    {

        List<Usuario> listaUsuario;
        public IULogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargaUsuarios();


        }

        private void cargaUsuarios()
        {
            listaUsuario = LNyAD.listarUsuario();
        }

        private void txtBoxUsu_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtBoxUsu.Text.Trim();
            string password = txtBoxPass.Text.Trim();

            if (!Error(usuario, password))
            {
                string passEncrypt = encriparContraseña(password);

                if (verificaUsuario(usuario,passEncrypt))
                {

                }
         
            }
        }

        private bool verificaUsuario(string usuario, string password)
        {
            for (int i = 0; i < listaUsuario.Count; i++)
            {
                if (usuario != listaUsuario[i].Login && password == listaUsuario[i].Password) ;
                {
                    usuario = LNyAD.ObtenerUsuarioPorId(listaUsuario[i].Id);
                }
            }
            return false;
        }

        private bool Error(string usuario, string password) //si falta casilla por rellenar
        {
            bool error = false;
            string message = "Falta : \n";
            if (usuario == "")
            {
                error = true;
                message += "   -nombre usuario. \n";
                errorProvider.SetError(txtBoxUsu, "Usuario Vacío");
            }
            if (password =="")
            {
                error = true;
                message += "  -Contraseña";
                errorProvider.SetError(txtBoxUsu, "Contraseña Vacío");
            }

            if (error)
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            return false;
        }
        private string encriparContraseña(string password)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(password);
            result = Convert.ToBase64String(encryted);
            return result;
        }
    }
}

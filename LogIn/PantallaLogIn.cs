using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn
{
    public partial class PantallaLogIn : Form
    {
        private int m, mX, mY;
        public PantallaLogIn()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mX = e.X;
            mY = e.Y;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                if (string.IsNullOrEmpty(usuario) && string.IsNullOrEmpty(contraseña))
                {
                     MessageBox.Show("Ingrese un usuario y una contraseña", "Datos vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                {
                    if (string.IsNullOrEmpty(usuario))
                    {
                        MessageBox.Show("Ingrese un usuario", "Dato vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (string.IsNullOrEmpty(contraseña))
                    {
                        MessageBox.Show("Ingrese una contraseña", "Dato vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }else
            {   
                MessageBox.Show($"Usuario: {usuario}\nContraseña: {contraseña}", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void barraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mX, MousePosition.Y - mY);
            }
        }

        private void barraTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }
}

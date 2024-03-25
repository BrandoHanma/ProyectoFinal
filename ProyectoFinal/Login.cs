using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProyectoFinal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
          private struct RGBcolors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(5, 10, 40);
            public static Color color8 = Color.FromArgb(5, 10, 65);

        }

        private void txtusuario(object sender, EventArgs e)
        {
            if (usuario.Text == "USUARIO")
            {
                usuario.Text = "";
                usuario.ForeColor = Color.LightGray;

            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (usuario.Text == "")
            {
                usuario.Text = "USUARIO";
                usuario.ForeColor = Color.LightGray;

            }
        }

        private void contrase_Enter(object sender, EventArgs e)
        {
            if (contrase.Text == "CONTRASEÑA")
            {
                contrase.Text = "";
                contrase.ForeColor = Color.LightGray;

            }

        }

        private void contrase_Leave(object sender, EventArgs e)
        {
            if (contrase.Text == "")
            {
                contrase.Text = "CONTRASEÑA";
                contrase.ForeColor = Color.LightGray;

            }
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
         private extern static void SendMessage(System.IntPtr hWnd,int wMsg, int wParam,int IParam);
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void btnsalida_MouseUp(object sender, MouseEventArgs e)
        {
          
        }

        private void btnsalida_MouseMove(object sender, MouseEventArgs e)
        {
            btnsalida.BackColor = Color.Red;
        }

        private void btnsalida_MouseLeave(object sender, EventArgs e)
        {
            btnsalida.BackColor = RGBcolors.color7;
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.BackColor = RGBcolors.color8;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = RGBcolors.color7;
        }

        private void linkLabel1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void linkLabel1_MouseLeave(object sender, EventArgs e)
        {

        }
    }
  
}

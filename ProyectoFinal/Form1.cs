using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using Color = System.Drawing.Color;
using System.Windows.Media.TextFormatting;
using System.Security.Principal;
namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        //campos
        private IconButton btnActual;
        private Panel panelizquierdobtn;
        private Form formhijoActual;

        public Form1()
        {
            InitializeComponent();

            panelizquierdobtn = new Panel();
            panelizquierdobtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(panelizquierdobtn);
            //Form
           // this.Text=string.Empty;
            this.ControlBox=false;
            this .DoubleBuffered=true;
            this.MaximizedBounds=Screen.FromHandle(this.Handle).WorkingArea;
        }
        //Colores
        private struct RGBcolors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(5, 10, 35);
            public static Color color8 = Color.FromArgb(5, 10, 60);
        }

        //metodos
        private void Activarbtn(object btn, Color color)
        {
            if (btn != null)
            {
                apagarbtn();
                //boton
                btnActual = (IconButton)btn;
                btnActual.BackColor = Color.FromArgb(37, 36, 81);
                btnActual.ForeColor = color;
                btnActual.TextAlign = ContentAlignment.MiddleCenter;
                btnActual.IconColor = color;
                btnActual.TextImageRelation = TextImageRelation.TextBeforeImage;
                btnActual.ImageAlign = ContentAlignment.MiddleRight;
                //boton izquierda
                panelizquierdobtn.BackColor = color;
                panelizquierdobtn.Location = new Point(0, btnActual.Location.Y);
                panelizquierdobtn.Visible = true;
                panelizquierdobtn.BringToFront();
                //icono actual
                iconActual.IconChar = btnActual.IconChar;
                iconActual.IconColor = color;

            }

        }
        private void apagarbtn()
        {

            if (btnActual != null)
            {
                labelIcon.Text = "Home";
                btnActual.BackColor = Color.FromArgb(5, 10, 29);
                btnActual.ForeColor = Color.Gainsboro;
                btnActual.TextAlign = ContentAlignment.MiddleCenter;
                btnActual.IconColor = Color.Gainsboro;
                btnActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnActual.ImageAlign = ContentAlignment.MiddleCenter;
            }

        }
        //form hijo
        private void abrirformHijo(Form formHijo)
        { 
        if (iconActual != null)
            {
               // solo abre form hijo
               formhijoActual.Close();
            }
            formhijoActual=formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelDes.Controls.Add(formHijo);
            panelDes.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            Activarbtn(sender, RGBcolors.color1);
            labelIcon.Text = "Dashboard";
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Activarbtn(sender, RGBcolors.color2);
            labelIcon.Text = "Ordenes";
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            Activarbtn(sender, RGBcolors.color3);
            labelIcon.Text = "Productos";
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Activarbtn(sender, RGBcolors.color4);
            labelIcon.Text = "Clientes";
        }

        private void iconButton5_Click_1(object sender, EventArgs e)
        {
            Activarbtn(sender, RGBcolors.color5);
            labelIcon.Text = "Ventas";
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            Activarbtn(sender, RGBcolors.color6);
            labelIcon.Text = "Ajustes";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            apagarbtn();
            panelizquierdobtn.Visible = false;
            iconActual.IconChar = IconChar.Home;
            iconActual.IconColor = Color.White;

        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,int wMsg, int wParam,int IParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (WindowState==FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelDes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = RGBcolors.color7;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        { 
            pictureBox3.BackColor = Color.Red;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackColor = RGBcolors.color7;
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
         
            pictureBox5.BackColor = RGBcolors.color8;
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.BackColor = RGBcolors.color8;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = RGBcolors.color7;
        }
    }
}

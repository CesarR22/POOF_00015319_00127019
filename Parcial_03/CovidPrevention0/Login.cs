using System;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{

    public partial class Login : Form

    {
        Formulario logeo;
        public Login()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "USUARIO")
            {

                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void Txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text=="")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.DimGray;

            }
        }

        private void Txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {

                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }

        }

        private void Txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void Txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            if ((txtuser.Text != "")&&(txtpass.Text != ""))
            {
                if ((txtuser.Text == "Admin") && (txtpass.Text == "pass"))
                {
                    logeo = new Formulario();
                    logeo.Show();
                    this.Hide();


                }

            }
        }
    }

    internal class Formulario
    {
        internal void Show()
        {
            throw new NotImplementedException();
        }
    }
}

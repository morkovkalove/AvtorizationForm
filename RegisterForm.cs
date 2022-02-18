using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            UserNameField.Text = "Введите имя";
            UserNameField.ForeColor = Color.Gray;

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void UserNameField_Enter(object sender, EventArgs e)
        {
            if(UserNameField.Text == "Введите имя")
            {
                UserNameField.Text = "";
                UserNameField.ForeColor = Color.Black;
            }

        }

        private void UserNameField_Leave(object sender, EventArgs e)
        {
            if (UserNameField.Text == "")
            {
                UserNameField.Text = "Введите текст";
                UserNameField.ForeColor = Color.Gray;
            }
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interface5
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void AvtorizationText_Click(object sender, EventArgs e)
        {

        }

        private void LoginText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        { 
            //получили данные от пользавателя
            String loginUser = LoginText.Text;
            String passUser = PasswordText.Text;
            if (loginUser == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (passUser == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            DB db= new DB();

            DataTable table=new DataTable();

            MySqlDataAdapter adapter =new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@uL AND `password`= @uP ", db.getConnection());

            command.Parameters.Add("@ul",MySqlDbType.VarChar).Value= loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand= command;
            adapter.Fill(table);
            //проверяем кол-во записей
            if (table.Rows.Count > 0)
            {
                this.Hide();
                BD bd = new BD();
                bd.Show();
            }

            else
                MessageBox.Show("Вы не зарегистрированы ");
        }
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void closebutton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closebutton_MouseEnter(object sender, EventArgs e)
        {
            closebutton.BackColor=Color.DarkRed;

        }

        private void closebutton_MouseLeave(object sender, EventArgs e)
        {
            closebutton.BackColor = Color.Red;
        }
        //Point-класс для задания координат
        Point lastPoint;
        //при передвижении мыши окно будет двигаться за ним
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button== MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint=new Point(e.X, e.Y);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm(); 
            registerForm.Show();
        }
    }
}

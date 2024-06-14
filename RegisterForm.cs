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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            

        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void closebutton_MouseEnter_1(object sender, EventArgs e)
        {
            closebutton.BackColor = Color.DarkRed;
        }

        private void closebutton_MouseLeave_1(object sender, EventArgs e)
        {
            closebutton.BackColor = Color.Red;
        }
        //Point-класс для задания координат
        Point lastPoint;
        //при передвижении мыши окно будет двигаться за ним
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            

        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            

        }

        private void userSurnameField_Enter(object sender, EventArgs e)
        {
            

        }

        private void userSurnameField_Leave(object sender, EventArgs e)
        {
           
        }

        private void LoginText_Enter(object sender, EventArgs e)
        {
           
        }

        private void LoginText_Leave(object sender, EventArgs e)
        {
        }

        private void PasswordText_Enter(object sender, EventArgs e)
        {
        
        }

        private void PasswordText_Leave(object sender, EventArgs e)
        {
     
        }

        private void RegitButton_Click(object sender, EventArgs e)
        {
            //получили данные от пользавателя
            String loginUser = LoginText.Text;
            String passUser = PasswordText.Text;
            String nameUser = userNameField.Text;
            String surnameUser = userSurnameField.Text;
            if (nameUser == "")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (surnameUser=="")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }
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
            

            //проверка
            if(isUserExists())
            {
                return;
            }


            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `surname`) VALUES (@login, @password, @name, @surname); ", db.getConnection());

            command.Parameters.Add("login", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("password", MySqlDbType.VarChar).Value = passUser;
            command.Parameters.Add("name", MySqlDbType.VarChar).Value = nameUser;
            command.Parameters.Add("surname", MySqlDbType.VarChar).Value = surnameUser;

            db.openConnection();

            if(command.ExecuteNonQuery()==1)
            {
                MessageBox.Show("Аккаунт был создан");
            }
            else 
            {
                MessageBox.Show("Аккаунт не был создан");
            }

            db.closeConnection();
           
        }
        public Boolean isUserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@uL ", db.getConnection());

            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = LoginText.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            //проверяем кол-во записей
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Логин уже существет,введите другой логин");
                return true;
            }
            else
            {
                this.Hide();
                BD bd = new BD();
                bd.Show();
                return false;
            }    
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoginText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterText_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userSurnameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface5
{
    internal class DB
    {
        //подключение к бд
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=users");

        //Функция для открыти соединения 
        public void openConnection() { 
        if(connection.State ==System.Data.ConnectionState.Closed) 
            connection.Open();
        }

        //Функция для закрытия соединения 
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        //функция возвращает само соединение
        public MySqlConnection getConnection()
        {
        return connection; }
    }
}

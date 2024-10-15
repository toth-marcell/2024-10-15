using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace _2024_10_15
{
    public static class Database
    {
        static MySqlConnection Connection;
        static MySqlCommand selectAllCmd;
        public static User ActiveUser;
        public static void OpenConnection()
        {
            Connection = new MySqlConnection($"Host=localhost;User=root;Password=");
            try
            {
                Connection.Open();
                new MySqlCommand("CREATE DATABASE IF NOT EXISTS `users`", Connection).ExecuteNonQuery();
                new MySqlCommand("USE `users`", Connection).ExecuteNonQuery();
                new MySqlCommand("CREATE TABLE IF NOT EXISTS `users` (`id` INT AUTO_INCREMENT PRIMARY KEY, `username` VARCHAR(50), `password` VARCHAR(50), `points` INT)", Connection).ExecuteNonQuery();
                selectAllCmd = new MySqlCommand("SELECT * FROM `users`", Connection);
                selectAllCmd.Prepare();
            }
            catch (Exception e)
            {
                ShowError(e);
            }
        }
        static void ShowError(Exception e)
        {
            MessageBox.Show(e.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        static void Delete(User user)
        {
            try
            {
                new MySqlCommand($"DELETE FROM `users` WHERE `id`={user.Id}", Connection).ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ShowError(e);
            }
        }
        static void DeleteAll()
        {
            try
            {
                new MySqlCommand($"DELETE FROM `users`", Connection).ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ShowError(e);
            }
        }
        static void Insert(User user)
        {
            try
            {
                new MySqlCommand($"INSERT INTO `users` (`username`, `password`, `points`) VALUES ('{user.Username}', '{user.Password}', {user.Points})", Connection).ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ShowError(e);
            }
        }
        static List<User> ReadAll()
        {
            List<User> users = new List<User>();
            try
            {
                MySqlDataReader reader = selectAllCmd.ExecuteReader();
                while (reader.Read()) users.Add(new User
                {
                    Id = reader.GetInt32("id"),
                    Username = reader.GetString("username"),
                    Password = reader.GetString("password"),
                    Points = reader.GetInt32("points")
                });
                reader.Close();
            }
            catch (Exception e)
            {
                ShowError(e);
            }
            return users;
        }
        static void Update(User user)
        {
            try
            {
                new MySqlCommand($"UPDATE `users` SET `points`={user.Points} WHERE `id`={user.Id}", Connection).ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ShowError(e);
            }
        }
        public static bool Register(string username, string password)
        {
            foreach (User user in ReadAll())
            {
                if (user.Username == username)
                {
                    MessageBox.Show("Username taken.");
                    return false;
                }
            }
            Insert(new User
            {
                Username = username,
                Password = password,
                Points = 0
            });
            foreach (User user in ReadAll())
            {
                if (user.Username == username)
                {
                    ActiveUser = user;
                    return true;
                }
            }
            return false;
        }
        public static bool Login(string username, string password)
        {
            foreach (User user in ReadAll())
            {
                if (user.Username == username)
                {
                    if (user.Password == password)
                    {
                        ActiveUser = user;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Wrong password!");
                        return false;
                    }
                }
            }
            MessageBox.Show("No such user!");
            return false;
        }
    }
}

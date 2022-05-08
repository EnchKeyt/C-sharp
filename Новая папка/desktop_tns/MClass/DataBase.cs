using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessia_2.MClass
{
    public class DataBase
    {
        SqlConnection connection = new SqlConnection(@"Data Source=WORLDSKILLS-ITB\SQLEXPRESS;Initial Catalog=ws05;Persist Security Info=True;User ID=ws05;Password=5N36%.mX");

        /// <summary>
        /// Открытие соединения с базой данных
        /// </summary>
        /// <returns>string message - состояние</returns>
        public string Open()
        {
            try
            {
                connection.Open();
                return "Соединение с базой данных успешно";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "Соединение с базой данных НЕ успешно";
        }
        /// <summary>
        /// Закрытие соединения с базой данных
        /// </summary>
        /// <returns>string message - состояние</returns>
        public string Close()
        {
            try
            {
                connection.Close();
                return "Соединение с базой данных успешно закрыто";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "Соединение с базой данных НЕ успешно закрыто";
        }

        public List<MClass.Users> SelectUserSotrudnik()
        {
            string query = "SELECT * FROM UserSotrudnik";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            List<MClass.Users> alluser = new List<Users>();
            while (reader.Read())
            {
                alluser.Add(new Users
                {
                    ИД = Int32.Parse(reader["ИД"].ToString()),
                    ФИО = reader["ФИО"].ToString(),
                    Должность = reader["Должность"].ToString(),
                    Фото = reader["Фото"].ToString()
                });
            }
            reader.Close();
            return alluser;
        }

        public List<MClass.Abonts> SelectAbonts()
        {
            string query = "SELECT * FROM AllAbonts";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            List<MClass.Abonts> alluser = new List<Abonts>();
            while (reader.Read())
            {
                alluser.Add(new Abonts
                {
                    Номер_абонента = reader["Номер_абонента"].ToString(),
                    ФИО = reader["ФИО"].ToString(),
                    Пол = reader["Пол"].ToString(),
                    Дата_рождения = reader["Дата_рождения"].ToString(),
                    Номер_телефона = reader["Номер_телефона"].ToString(),
                    Электронная_почта = reader["Электронная_почта"].ToString(),
                    Адрес_прописки = reader["Адрес_прописки"].ToString(),
                    Адрес_проживания = reader["Адрес_проживания"].ToString(),
                    Серия_и_номер_паспорта = reader["Серия_и_номер_паспорта"].ToString(),
                    Код_подразделения = reader["Код_подразделения"].ToString(),
                    Кем_выдан = reader["Кем_выдан"].ToString(),
                    Дата_выдачи_паспорта = reader["Дата_выдачи_паспорта"].ToString(),
                    Номер_договора = reader["Номер_договора"].ToString(),
                    Дата_заключения_договора = reader["Дата_заключения_договора"].ToString(),
                    Тип_договора = reader["Тип_договора"].ToString(),
                    Причина_расторжения_договора = reader["Причина_расторжения_договора"].ToString(),
                    Лицевой_счет = reader["Лицевой_счет"].ToString(),
                    Услуги = reader["Услуги"].ToString(),
                    Услуги1 = reader["Услуги1"].ToString(),
                    Услуги2 = reader["Услуги2"].ToString(),
                    Дата_расторжения_договора = reader["Дата_расторжения_договора"].ToString(),
                    F22 = reader["F22"].ToString(),
                    Серийный_номер_оборудования = reader["Серийный_номер_оборудования"].ToString(),
                }) ;
            }
            reader.Close();
            return alluser;
        }
    }
}

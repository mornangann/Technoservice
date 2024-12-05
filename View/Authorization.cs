using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ОООТехносервис.Classes;
using ОООТехносервис.View;

namespace ОООТехносервис
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
           
        }
        private void Authorization_Load(object sender, EventArgs e)
        {
            //Создать подключение к бд
            try
            {
                Helper.DBRequest = new model.DBConnectRequest();
                MessageBox.Show("Успешное подключение к БД");
            }
            catch
            {
                MessageBox.Show("Неудачное подключение к БД");
                Environment.Exit(-1); // Выход из приложения
            }
        }

        //вход в систему
        /* private void logIn_Click(object sender, EventArgs e)
         {
             string login, password;
             FiltrSearch filtrSearch = new FiltrSearch();
             login = textBoxLogIn.Text;
             password = textBoxPasswd.Text;
             List<model.User> users = Helper.DBRequest.User.ToList();
             //1 пользовавтель
             model.User user = null;
             //перебои пользователей
             foreach (model.User u in users)
             {
                 if (u.UserLogin == login && u.UserPassword == password)
                 {
                     user = u;

                     break;
                 }
             }
             if (user != null)
             {
                 MessageBox.Show("Нашли. Вы вошли с ролью " + user.Role.RoleName);
                 this.Hide();
                 filtrSearch.Show();

             }
             else
             {
                 MessageBox.Show("Не нашли");
             }
         }*/

        private void logIn_Click(object sender, EventArgs e)
        {
            //Получили данные от пользователя из интерфейса
            string login = textBoxLogIn.Text;
            string password = textBoxPasswd.Text;

            ////////////Результат запроса на получение всех пользователей
            //////////List<Model.User>   users =  Classes.Helper.DBRequest.User.ToList();
            ////////////Один пользователь
            //Model.User user=null;
            //////////Список отфильтраванных пользователей
            ////////List<Model.User> usersWhere = users.Where(u=>u.UserLogin == login && u.UserPassword == password).ToList();
            //////////Первый из отфильтрованных
            ////////user = usersWhere.FirstOrDefault();

            Helper.user = Classes.Helper.DBRequest.User.Where(u => u.UserLogin == login &&
            u.UserPassword == password).FirstOrDefault();

            ////////////////Перебор всех пользователей
            //////////////foreach (Model.User u in users) 
            //////////////{
            //////////////    if (u.UserLogin == login && u.UserPassword == password) //Нашли
            //////////////    {
            //////////////        user = u;
            //////////////        break;
            //////////////    }
            //////////////}

            if (Helper.user != null)
            {
                MessageBox.Show("Нашли. Вы вошли с ролью " + Helper.user.Role.RoleName);

                //Отобразить окно
                View.FiltrSearch listRequests = new View.FiltrSearch();   //Создали дополнительное окно
                this.Hide();    //Временно скрыли окно авторизации this - ссылка на окно, в котором сейчас находимся
                listRequests.ShowDialog();  //Открыть окно списка
                this.Show();        //Показать окно авторизации после закрытия окна списка
            }
            else
            {
                MessageBox.Show("Не нашли");
            }

        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

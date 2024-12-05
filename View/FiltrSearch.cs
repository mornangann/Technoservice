using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ОООТехносервис.Classes;
using ОООТехносервис.model;

namespace ОООТехносервис.View
{
    public partial class FiltrSearch : Form
    {
        public FiltrSearch()
        {
            InitializeComponent();
        }

        /*private void FiltrSearch_Load(object sender, EventArgs e)
        {
            List<model.Status> statuses = Classes.Helper.DBRequest.Status.ToList();
            model.Status status = new model.Status();
            status.StatusId = 0;
            status.StatusName = "Все статусы";
            statuses.Insert(0, status);
            comboBoxStatus.DisplayMember = "StatusName";
            comboBoxStatus.ValueMember = "StatusId";
            comboBoxStatus.SelectedIndex = 0;
            int i = 0;
            List<model.Request> requests = Classes.Helper.DBRequest.Request.ToList();
            this.dataGridViewRequests.Rows.Clear();
            foreach (model.Request request in requests)
            {
                this.dataGridViewRequests.Rows.Add();
                dataGridViewRequests.Rows[i].Cells[0].Value = request.RequestId;
                dataGridViewRequests.Rows[i].Cells[1].Value = request.RequestDate;
                dataGridViewRequests.Rows[i].Cells[2].Value = request.Device.DeviceName;
                dataGridViewRequests.Rows[i].Cells[3].Value = request.User.UserFullName;
                dataGridViewRequests.Rows[i].Cells[4].Value = request.Status.StatusName;
                dataGridViewRequests.Rows[i].Cells[5].Value = request.User1.UserFullName;
                dataGridViewRequests.Rows[i].Cells[6].Value = request.Stage.StageName;
                i++;
            }
        }*/


        public void ShowRequests()
        {
            //Получить из БД все заявки
            List<model.Request> list = Classes.Helper.DBRequest.Request.ToList();


            //Анализ вошедшей роли
            switch (Helper.user.Role.RoleId)
            {
                case 1:     //Заказчик
                            //Отобразить заявки этого заказчика
                    list = list.Where(r => r.RequestClientId == Helper.user.UserId).ToList();
                    break;
                case 2: //Мастер
                        //Отобразить заявки этого мастера
                    list = list.Where(r => r.RequestMasterID == Helper.user.UserId).ToList();
                    buttonEditRequest.Visible = true;    //Доступно редактирование
                    break;
                case 3: //Оператор - доступны все заявки
                        //Доступны кнопки добаления и редактирование
                    buttonEditRequest.Visible = buttonAddRequest.Visible = true;
                    break;
                case 4: //Менеджер - доступны все заявки
                        //Доступна кнопка отчетов
                    buttonReport.Visible = true;
                    break;
            }

            //Фильтровать по статусу
            int numberStatus = (int)comboBoxStatus.SelectedIndex;   //Номер выбранного статуса
            if (numberStatus > 0)      //Если не "Все статусы"
            {
                //Фильтровать весь список по выбранному статусу
                list = list.Where(r => r.RequestStatusID == numberStatus).ToList();
            }

            //Поиск по номеру
            if (textBoxNumber.Text != "")     //Строка для поиска не пустая
            {
                //Фильтровать записи, в номере которых есть введенные цифры в строке поиска
                list = list.Where(r => r.RequestId.ToString().Contains(textBoxNumber.Text)).ToList();
            }

            //Подготовиться к выводу всех отобранных записей
            this.dataGridViewRequests.Rows.Clear();
            int i = 0;      //Счетчик строк
                            //Цикл по перебору всех заявок
            foreach (model.Request request in list)
            {
                this.dataGridViewRequests.Rows.Add();
                dataGridViewRequests.Rows[i].Cells[0].Value = request.RequestId;
                var date = request.RequestDate ?? DateTime.MinValue;
                if (date != DateTime.MinValue)
                {
                    dataGridViewRequests.Rows[i].Cells[1].Value = date.ToLongDateString();

                }

                //dataGridViewRequests.Rows[i].Cells[2].Value = request.RequestDeviceId;
                dataGridViewRequests.Rows[i].Cells[2].Value = request.Device.DeviceName;
                dataGridViewRequests.Rows[i].Cells[3].Value = request.User.UserFullName;
                dataGridViewRequests.Rows[i].Cells[4].Value = request.Status.StatusName;
                dataGridViewRequests.Rows[i].Cells[5].Value = request.User1.UserFullName;
                dataGridViewRequests.Rows[i].Cells[6].Value = request.Stage.StageName;
                i++;        //Номер следующей строки в таблице
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// При загрузке окна отобразить список заявок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FiltrSearch_Load(object sender, EventArgs e)
        {
            //Заполнить comboBox статусами из БД
            List<model.Status> statuses = Classes.Helper.DBRequest.Status.ToList();
            //Новый статус, которого нет в БД
            model.Status status = new model.Status();
            status.StatusId = 0;
            status.StatusName = "Все статусы";
            //Добавить новый статус к статусам из БД
            statuses.Insert(0, status);
            //Перенос списка статусов в ComboBox
            comboBoxStatus.DataSource = statuses;
            //Какое поле будет видеть пользователь
            comboBoxStatus.DisplayMember = "StatusName";
            //Из какого поля будем получать значение для фильтрации
            comboBoxStatus.ValueMember = "StatusId";
            comboBoxStatus.SelectedIndex = 0;   //Сделать первый статус активным
                                                //Отобразить список заявок
            ShowRequests();
        }

        /// <summary>
        /// Выбор статуса для фильтрации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowRequests();
        }

        /// <summary>
        /// Ввод номера заявки для поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {
            ShowRequests();
        }

        /// <summary>
        /// Добавить заявку для роли оператор
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddRequest_Click(object sender, EventArgs e)
        {
            //Создать окно одной заявки и передать ему значение 0
            //Т.к. для новой заявки нет номера выбранной заявки
            //Можно любое число, хоть отрицательное, занчения которого нет в id заявок
            View.WorkRequest workRequest = new View.WorkRequest(0);
            this.Hide();
            workRequest.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Редактировать выбранную запись
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditRequest_Click(object sender, EventArgs e)
        {
            //Проверили, что есть выбранная заявка
            if (dataGridViewRequests.SelectedRows.Count > 0)
            {
                //Номер выбранной заяки
                int id = (int)dataGridViewRequests.CurrentRow.Cells[0].Value;
                //Открыли окна и передали внего номер выбранной заявки
                View.WorkRequest workRequest = new View.WorkRequest(id);
                this.Hide();
                workRequest.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Не выбрана заявка для реактирования");
            }
        }
    }
}

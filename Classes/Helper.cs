using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОООТехносервис.Classes
{
    //Класс с глобальными величинами для всего проекта
    internal class Helper
    {
        //Связка с БД
        public static model.DBConnectRequest DBRequest { get; set; }

        //Пользователь, вошедший в систему
        public static model.User user;
    }
}

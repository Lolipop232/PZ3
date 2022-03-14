using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class train // публичный (открытый) класс train для хранения информации о поездах
    {
        public int id;
        public string train_driver;
        public string model;
        public train (string train) // конструктор класса train c входным параметром
        {
            this.model = model;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class ticket // Открытый класс ticket 
    {
        public int Id;
        public person person; //поле класса ticket типа person с названием person
        public train train;
        // поле класса
        public ticket(int Id) // конструктор класса ticket c входным параметром
        {
            this.Id = Id;
        }
    }
}

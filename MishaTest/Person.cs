using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishaTest
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public int D { get; set; } //(достовiрнiсть)
        public int PR { get; set; } //(психiчна регуляцiя)
        public int KP { get; set; } //(комунiкативний потенцiал)
        public int MN { get; set; } //(моральна нормативнiсть)
        public int VPS { get; set; } //(вiйськово-професiйна спрямованiсть)
        public int DAP { get; set; } //(схильнiсть до девiантних форм поведiнки)
        public int SR { get; set; } //(суїцидальний ризик)
        public int OAP { get; set; } // ОАП
    }
}

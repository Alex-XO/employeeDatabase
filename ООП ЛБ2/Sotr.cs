using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_ЛБ2
{
    public abstract class Sotr
    {
        private string Fam;
        string Name;
        string Otch;
        public string fam
        {
            get
            {
                return Fam;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Строка Фамилия не может быть пустой");
                }
                else
                    Fam = value;

            }
        }
        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Строка Имя не может быть пустой");
                }
                else
                    Name = value;

            }
        }
        public string otch
        {
            get
            {
                return Otch;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Строка Отчество не может быть пустой");
                }
                else
                    Otch = value;

            }
        }

        public bool IsThisSotr(string f, string n, string o)
        {
            if (fam != f)
                return false;
            if (name != n)
                return false;
            if (otch != o)
                return false;
            return true;
        }

        public abstract int GetSalary();
       
        public Sotr (string f, string n, string o)
        {
            fam = f;
            name = n;
            otch = o;
        }
    }
}

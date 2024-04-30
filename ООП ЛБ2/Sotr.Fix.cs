using System;

namespace ООП_ЛБ2
{
    public class SotrFix : Sotr
    {
        public int Summa
        {
            get;
            private set;
        }

        public override int GetSalary()
        {
            return Summa;
        }

        public SotrFix(string f, string n, string o, int s)
            : base(f, n, o)
        {
            SetSumma(s);
        }

        private void SetSumma(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Заработанная плата не может быть отрицательным числом.");
            }
            Summa = value;
        }
    }
}

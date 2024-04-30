using System;

namespace ООП_ЛБ2
{
    public class SotrDaycs : Sotr
    {
        private int _count;
        private int _stoim;

        public int Count
        {
            get => _count;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), "Количество дней не может быть отрицательным числом");
                _count = value;
            }
        }

        public int Stoim
        {
            get => _stoim;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), "Оплата за день не может быть отрицательной");
                _stoim = value;
            }
        }

        public override int GetSalary() => Count * Stoim;

        public SotrDaycs(string f, string n, string o, int c, int s)
            : base(f, n, o)
        {
            Count = c;
            Stoim = s;
        }
    }
}

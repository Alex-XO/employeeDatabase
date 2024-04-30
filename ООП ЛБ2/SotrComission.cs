using System;

namespace ООП_ЛБ2
{
    class SotrComission : Sotr
    {
        private int _summa;
        private float _percent; // от 0 до 1

        public int Summa
        {
            get => _summa;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), "Сумма продаж не может быть отрицательным числом");
                _summa = value;
            }
        }

        public float Percent
        {
            get => _percent;
            set
            {
                if (value < 0 || value > 1)
                    throw new ArgumentOutOfRangeException(nameof(value), "Процент должен быть в диапазоне от 0 до 1");
                _percent = value;
            }
        }

        public override int GetSalary()
        {
            return (int)(_summa * _percent);
        }

        public SotrComission(string f, string n, string o, int s, float p)
            : base(f, n, o)
        {
            Summa = s;
            Percent = p;
        }
    }
}


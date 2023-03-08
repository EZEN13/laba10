using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLab10
{
    public class Avto : Transport
    {
        protected double oil;

        [ExcludeFromCodeCoverage]
        public double OIL
        {
            set
            {
                if (value >= 0)
                {
                    oil = value;
                }
                else
                {
                    oil = 0;
                }
            }
            get { return oil; }
        }
        public Avto(int wheels, int doors, double oil) : base(wheels, doors)
        {
            {
                OIL = oil;
            }   
        }

        public Avto() : base()
        {

        }
        public override void RandomInit()
        {
            base.RandomInit();
            OIL = rnd.NextDouble() * 25;
        }

        [ExcludeFromCodeCoverage]
        public override bool Equals(object obj)
        {
            if (obj is Avto s)
            {
                return this.Wheels == s.Wheels & this.Doors == s.Doors & this.OIL == s.OIL;
            }
            else
            {
                return false;
            }
        }

        public override void Show()
        {
            base.Show(); Console.WriteLine($"Кол-во топлива в т/c: {OIL} л.");
        }

        [ExcludeFromCodeCoverage]
        public override Type GetType(object obj)
        {
            return obj.GetType();
        }

        [ExcludeFromCodeCoverage]
        public override void Init()
        {
            base.Init();

            Console.WriteLine("Введите кол-во топлива т/с");

            OIL = Input.ReadDouble();
        }


    }
}

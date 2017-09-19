using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY19092017
{
    class Car:IComparable
    {
        public string licencePlate;
        public int year;
        public string brand;
        public double engineSize;

        public Car(string licencePlate,int year
            ,string brand,double engineSize)
        {
            this.licencePlate = licencePlate;
            this.year = year;
            this.brand = brand;
            this.engineSize = engineSize;
        }

        public int CompareTo(Object obj)
        {
            Car obj1=((Car)obj);
            if (engineSize < obj1.engineSize)
                return -1;
            else if (engineSize == obj1.engineSize)
                return 0;
            else
                return 1;
        }

        public override string ToString()
        {
            return licencePlate;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationPractice
{
    public class Car
    {
        private string _brand;
        private string _model;
        private string _clour;
        private int _doorCount;


        public string Brand { get { return _brand; } set { _brand = value; } }
        public string Model { get { return _model; } set { _model = value; } }
        public string Clour { get { return _clour; } set { _clour = value; } }
        public int DoorCount
        {
            get { return _doorCount; }

            set
            {
                if (value == 2 || value == 4)
                {
                    _doorCount = value;
                }

                else
                {
                    _doorCount = -1;
                    Console.WriteLine("Kapı sayısı sadece 2 ve 4 olabilir.");
                }
            }
        }

        public Car()
        {

        }

        public Car(string _brand, string _model, string _clour, int _doorCount)
        {
            Brand = _brand;
            Model = _model;
            Clour = _clour;
            DoorCount = _doorCount;
        }

        public void CarResult()
        {
            Console.WriteLine($"Arabanın markası: {_brand}\nArabanın modeli: {_model}\nArabanın rengi: {_clour}\nArabanın Kapı Sayısı: {_doorCount}");
        }


    }
}

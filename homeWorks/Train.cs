using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorks
{
    public class Train
    {
        private int _id; //Айдишник поезда
        private string _distination; // Маршрут типо Астана - Алматы 
        private int _carriageNum;  // количество вагонов
        private Driver _driver = new Driver(); //водитель поезда 
        private string _infoOfTrain; //инфа о поезда по типу модель, дата выпуска и страна производства

        public Train()
        {
            _distination = "Astana - Almaty";
            _carriageNum = 15;
            _driver.Id = 1;
            _driver.Name = "Максим Петров";
            _driver.Experience = 10;
            _infoOfTrain = "Поезд TrainCup 2015 г.в\n Германия. Берлин";
        }

        public Train(string distination, int carriageNum, Driver driver, string info)
        {
            _distination = distination;
            _carriageNum = carriageNum;
            _driver.Id = driver.Id;
            _driver.Name = driver.Name;
            _driver.Experience = driver.Experience;
            _infoOfTrain = info;

        }

        public int Id
        {
            get{ return _id; }
            set{ _id = value;}
        }

        public string Distination
        {
            get { return _distination; }
            set { _distination = value; }
        }

        public int CarriageNum
        {
            get { return _carriageNum; }
            set { _carriageNum = value; }
        }

        public string Info
        {
            get { return _infoOfTrain; }
            set { _infoOfTrain = value; }
        }

        public string GetFullInfo()
        {
            string result = Info;
            string result2 = ("\nNumber of carriages: - " + CarriageNum + "\nDistination: - " + Distination);
            return result + result2;
        }

    }
}

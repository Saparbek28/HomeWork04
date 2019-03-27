using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Airplane
    {
        private string _name;
        private string _color;

        private string _type;
        private int _speed;
        private int _places;
        private int _size;
        private static int _count;

        #region GetSet

        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }


        public int Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
            }
        }

        public int Plasec
        {
            get
            {
                return _places;
            }
            set
            {
                _places = value;
            }
        }

        public int Size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = value;
            }
        }
        #endregion

        #region Info
        public Airplane(string Name, string Color, string Type, int Speed, int Places, int Size)
        {
            Name = _name;
            Color = _color;
            Type = _type;
            Speed = _speed;
            Places = _places;
            Size = _size;

            _count++;
        }
        public Airplane()
        {
            Size = 50;
            Plasec = 30;
            Speed = 2500;

            _count++;

        }


        #endregion

        public void DifeneAirplane()
        {
            if (Type == "Пассажирский" && _count == 0)
            {
                Name = "Су-220";
                Speed = 2500;
                Plasec = 30;
                Size = 50;
            }
        }

        public string AirplaneInfo()
        {
            return string.Format("Name: {0} \n Color: {1} \n Type: {2} \n Speed: {3} \n Places {4} \n Size: {5}",
                Name, Color, _type, Speed, Plasec, Size);

        }

        public void PaperInfo(out string[] info)
        {
            int size = 6;
            info = new string[size];
            info[1] = "Name: " + _name;
            info[2] = "Color: " + Color;
            info[3] = "Type: " + _type;
            info[4] = "Places: " + Plasec;
            info[5] = "Size: " + Size;
            info[6] = "Speed: " + Speed;
        }

    }

}

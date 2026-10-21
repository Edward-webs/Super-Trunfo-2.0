using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Trunfo_2._0.Classes
{
    public class Carta
    {
        private string _code;
        private string _name;
        private int _hp;
        private int _power;
        private int _speed;
        private int _strength;
        private int _resistance;

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Hp
        {
            get { return _hp; }
            set { _hp = value; }
        }
        public int Power
        {
            get { return _power; }
            set { _power = value; }
        }
        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }
        public int Strength
        {
            get { return _strength; }
            set { _strength = value; }
        }
        public int Resistance
        {
            get { return _resistance; }
            set { _resistance = value; }
        }

        public bool Supertrunfo
        {
            get; set;
        }

        public Carta(string code, string name, int hp, int power, int speed, int strength, int resistance, bool supertrunfo = false)
        {
            _code = code;
            _name = name;
            _hp = hp;
            _power = power;
            _speed = speed;
            _strength = strength;
            _resistance = resistance;
            Supertrunfo = supertrunfo;
        }

        public void displayCard()
        {
            if (Supertrunfo)
            {
                Console.WriteLine("Carta Super Trunfo!");
            }

            Console.WriteLine("\n------- SUA CARTA -------");
            Console.WriteLine($"[{_code}] {_name}");
            Console.WriteLine($"A. HP: {_hp}");
            Console.WriteLine($"B. Poder: {_power}");
            Console.WriteLine($"C. Velocidade: {_speed}");
            Console.WriteLine($"D. Força: {_strength}");
            Console.WriteLine($"E. Resistência: {_resistance}");
            Console.WriteLine("------------------------");
        }
    }
}

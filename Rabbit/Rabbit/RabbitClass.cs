using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Rabbit
{
    class RabbitClass
    {
        public string eyesRabbit;
        public string furOfRabbit;
        public string gender;
        public int ageOfRabbit;

        //•	a rabbit can have Blue, Red or Black eyes
        public string EyesRabbit
        {
            get
            {
                return this.eyesRabbit;
            }
            set
            {
                if (value != "blue" && value != "red" && value != "black")
                {
                    Console.WriteLine($"Color of the eyes cannot  be {value}");
                }
                else
                {
                    this.eyesRabbit = value;
                    Console.WriteLine($"The rabbit has {this.EyesRabbit} eyes");
                }
            }
        }
        //•	a rabbit's fur can be white, brown, black or grey
        //•	it has a gender
        public string FurOfRabbit
        {
            get
            {
                return this.furOfRabbit;
            }
            set
            {
                if (value != "white" && value != "brown" && value != "black" && value != "grey")
                {
                    Console.WriteLine($"Color of the fur cannot  be {value}");
                }
                else
                {
                    this.furOfRabbit = value;
                    Console.WriteLine($"The color of rabbit's fur is: {this.furOfRabbit}");
                }
            }
        }
        //•	it has a gender
        public string Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                if (value != "male" && value != "female")
                {
                    Console.WriteLine("The gender is not ok!");
                }
                else
                {
                    this.gender = value;
                    Console.WriteLine($"My rabbit has the gender:{this.Gender}");
                }
            }
        }
        //•	has a birth date, and based on that you should be able to see how old the rabbit is
        public int AgeOfRabbit
        {
            get
            {
                var yearOfBirthday = DateTime.Parse("10/20/1989", new CultureInfo("en-US")).Year;
                var age = DateTime.Now.Year - yearOfBirthday;
                return age;
            }
            set
            {
                this.ageOfRabbit = value;
            }
        }
        //•	we also know that a rabbit is a mammal that moves, sleeps and eats
        public void MoveRabbit()
        {
            Console.WriteLine($"My rabbit can move.");
        }
        public void SleepRabbit()
        {
            Console.WriteLine($"My rabbit can sleep.");
        }
        public void EatRabbit()
        {
            Console.WriteLine($"My rabbit likes to eat alot.");
        }
    }
}


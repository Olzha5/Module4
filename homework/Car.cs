using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    using System;

    // "Car" классы - автомобильдің өзгергіштерін және әрекеттерін сипаттау үшін
    public partial class Car
    {
        // Өзгергіштерінің баяндамалары
        private string make; // автомобильдің бренді
        private string model; // моделі
        private int year; // өндіру жылы
        private double price; // автомобильдің бағасы
        private bool isRunning; // автомобиль іске қосылды ма?
        private static int numberOfCars; // 
        private static string carCategory = "Седан"; 

        // Бос конструктор
        public Car()
        {
            make = "Unknown"; // бренді белгісіз
            model = "Unknown"; // моделі белгісіз
            year = DateTime.Now.Year; // автомобильдің өндіру жылы - ағымдағы жыл
            price = 0.0; // бағасы 0
            isRunning = false; // іске қосылмаған
            numberOfCars++; // автомобильдер санын 1-ге көбейтеміз
        }

        // Параметрлі конструктор
        public Car(string make, string model, int year, double price)
        {
            this.make = make; // бренді
            this.model = model; // моделі
            this.year = year; // өндіру жылы
            this.price = price; // бағасы
            isRunning = false; // іске қосылмаған
            numberOfCars++; // автомобильдер санын 1-ге көбейтеміз
        }

        // Параметрлі конструктор
        public Car(string make, string model, int year, double price, bool isRunning)
        {
            this.make = make; // бренді
            this.model = model; // моделі
            this.year = year; // өндіру жылы
            this.price = price; // бағасы
            this.isRunning = isRunning; // іске қосылды ма?
            numberOfCars++; // автомобильдер санын 1-ге көбейтеміз
        }

        // Бренд қасиеті
        public string Make
        {
            get { return make; } // брендді қайтару
            set { make = value; } // брендді өзгерту
        }

        // Модель қасиеті
        public string Model
        {
            get { return model; } // моделді қайтару
            set { model = value; } // моделді өзгерту
        }

        // Өндіру жылы қасиеті
        public int Year
        {
            get { return year; } // өндіру жылын қайтару
            set { year = value; } // өндіру жылын өзгерту
        }

        // Баға қасиеті
        public double Price
        {
            get { return price; } // бағаны қайтару
            set { price = value; } // бағаны өзгерту
        }

        // Автомобиль іске қосылды ма?
        public bool IsRunning
        {
            get { return isRunning; } // жауабын қайтару
            set { isRunning = value; } // жауабын өзгерту
        }

        // Машинаны іске қосу әрекеті
        public void StartEngine()
        {
            isRunning = true; // іске қосылды
        }

        // Машинаны тоқтату әрекеті
        public void StopEngine()
        {
            isRunning = false; // тоқтатылды
        }

        // Бағаны өзгерту әрекеті
        public void ModifyPrice(ref double newPrice)
        {
            price = newPrice; // бағаны өзгертеміз
        }

        // Жаратылған автомобильдер саны қасиеті
        public static int NumberOfCars
        {
            get { return numberOfCars; } // санын қайтару
        }

        // Автомобиль санаты қасиеті
        public static string CarCategory
        {
            get { return carCategory; } // санатын қайтару
            set { carCategory = value; } // санатын өзгерту
        }
    }

    // "Car" классының кеңейтілген бөлігі
    public partial class Car
    {
        // Машинаны жылдамдату әрекеті
        public void Accelerate()
        {
            if (isRunning) ; // егер машина іске қосылс
        }
    }
}
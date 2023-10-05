//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace lab03
//{
//    internal class task2
//    {
//        private static void Main()
//        {
//            Car car1 = new Car("audi A5", "3.2 FSI", 204);
//            Car car2 = new Car("audi A5", "3.2 FSI", 204);
//            Car car3 = new Car("audi A5", "S5", 220);
//            Console.WriteLine(car1.ToString());
//            Console.WriteLine(car1.Equals(car2));
//            Console.WriteLine(car1.Equals(car3));
//            Console.WriteLine(car1.MaxSpeed);
//            CarsCatalog catalog = new CarsCatalog(car1, car2, car3);
//            Console.WriteLine($"{catalog[0]}\n{catalog[2]}");
//        }
//    }
//    public class Car : IEquatable<Car>
//    {
//        private string _name, _engine;
//        private double _speed;
//        public Car(string name, string engine, double speed) { _engine = engine; _name = name; _speed = speed; }
//        public string Name { get { return _name; } }
//        public string Engine { get { return _engine; } }
//        public double MaxSpeed { get { return _speed; } }

//        public bool Equals(Car? other) { return other.Name == Name && other.Engine == Engine && other.MaxSpeed == MaxSpeed; }

//        public override string ToString() => Name;
//    }
//    public class CarsCatalog
//    {
//        private List<Car> _cars;
//        public CarsCatalog(params Car[] cars) { _cars = new List<Car> { }; foreach (Car car in cars) _cars.Add(car); }
//        public string this[int index] { get => $"{_cars[index].Name} {_cars[index].Engine}"; }
//    }
//}

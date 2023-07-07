using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class CarList
    {
        public List<Car> _list;

        public CarList()
        {
            _list = new List<Car>();
        }

        public void AddCar(Car car)
        {
            _list.Add(car);
                Console.WriteLine($"You added Car: {car.Model} , {car.Type}, {car.Model}");
        }
        public void GetCar() 
        {
            if (_list.Count > 0)
            {
                foreach (Car item in _list)
                {
                    Console.WriteLine($"You added Car: {item.Model} , {item.Type}, {item.Model}");
                }
            }else
            {
                Console.WriteLine("List Is Empty");
            }
        }
    }
}

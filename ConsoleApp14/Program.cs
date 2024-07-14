
using ConsoleApp14;

class Program
{
    static void Main(string[] args)
    {
        CarGallery gallery = new CarGallery { Name = "Rubab's Gallery" };

        gallery.AddCar(new Car { Id = 1, Marka = "Bmw", Model = "x7", Year = 2024 });
        gallery.AddCar(new Car { Id = 2, Marka = "Bmw", Model = "x5", Year = 2023 });

        gallery.GetAllCars();

        gallery.SaveToJson("cars.json");

        Console.WriteLine(" saved to cars.json");
    }
}
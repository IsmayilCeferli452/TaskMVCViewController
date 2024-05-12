using AspTask.Models;
using AspTask.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeVM model = new HomeVM()
            {
                Students = GetAllStudents(),
                Products = GetAllProducts(),
                StudentsDesc = GetAllStudentsDesc(),
                ProductsCount = GetProductsCount()
            };
            return View(model);
        }

        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>()
            {
                new Student()
                {
                    Name = "Ismayil",
                    Surname = "Ceferli",
                    Email = "ismayil@gmail.com",
                    Age = 24,
                    Number = "12345"
                },

                new Student()
                {
                    Name = "Afide",
                    Surname = "Veliyeva",
                    Email = "afide@gmail.com",
                    Age = 38,
                    Number = "1234567"
                },

                new Student()
                {
                    Name = "Nesir",
                    Surname = "Dadashov",
                    Email = "nesir@gmail.com",
                    Age = 29,
                    Number = "123"
                }
            };
            return students;
        }

        public List<Student> GetAllStudentsDesc()
        {
            List<Student> students = new List<Student>()
            {
                new Student()
                {
                    Name = "Ismayil",
                    Surname = "Ceferli",
                    Email = "ismayil@gmail.com",
                    Age = 24,
                    Number = "12345"
                },

                new Student()
                {
                    Name = "Afide",
                    Surname = "Veliyeva",
                    Email = "afide@gmail.com",
                    Age = 38,
                    Number = "1234567"
                },

                new Student()
                {
                    Name = "Nesir",
                    Surname = "Dadashov",
                    Email = "nesir@gmail.com",
                    Age = 29,
                    Number = "123"
                }
            };
            return students.OrderByDescending(m => m.Age).ToList();
        }

        public List<Product> GetAllProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Name = "Iphone",
                    Color = "Black",
                    Price = 2000,
                },

                new Product()
                {
                    Name = "Samsung",
                    Color = "White",
                    Price = 1000,
                },

                new Product()
                {
                    Name = "Xiaomi",
                    Color = "Grey",
                    Price = 500,
                },
            };
        }

        public int GetProductsCount()
        {
            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    Name = "Iphone",
                    Color = "Black",
                    Price = 2000,
                },

                new Product()
                {
                    Name = "Samsung",
                    Color = "White",
                    Price = 1000,
                },

                new Product()
                {
                    Name = "Xiaomi",
                    Color = "Grey",
                    Price = 500,
                },
            };

            return products.Count;
        }
    }
}

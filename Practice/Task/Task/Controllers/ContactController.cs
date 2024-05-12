using Microsoft.AspNetCore.Mvc;
using Task.Models;
using Task.ViewModels;

namespace Task.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            string text = "Students";
            List<string> studentList = new List<string> { "Ismayil", "Afide", "Nesir" };

            HomeVM model = new()
            {
                Text = text,
                Students = studentList,
                Users = GetAll()
            };

            return View(model);
        }

        private List<User> GetAll()
        {
            return new List<User>()
            {
                new User()
                {
                    Id = 1,
                    Age = 10,
                },

                new User()
                {
                    Id = 2,
                    Age =20,
                }
            };
        }
    }
}

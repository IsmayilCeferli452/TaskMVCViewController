using AspTask.Models;

namespace AspTask.ViewModels
{
    public class HomeVM
    {
        public List<Student> Students { get; set; }
        public List<Product> Products { get; set; }
        public List<Student> StudentsDesc { get; set; }
        public int ProductsCount { get; set; }
    }
}

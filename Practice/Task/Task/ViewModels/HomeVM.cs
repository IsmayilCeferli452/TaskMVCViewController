using Task.Models;

namespace Task.ViewModels
{
    public class HomeVM
    {
        public string Text { get; set; }
        public List<string> Students { get; set; }
        public List<User> Users { get; set; }
    }
}

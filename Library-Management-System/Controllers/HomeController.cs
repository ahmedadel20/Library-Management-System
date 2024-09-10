using Library_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Library_Management_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //using MyDBContext dbContext = new MyDBContext();

            //List<Book> books = new List<Book>();
            //books.Add(new Book
            //{
            //    Title = "The Shining",
            //    Author = "Stephen King",
            //    Genre = "Horror",
            //    Cover = "https://covers.openlibrary.org/b/id/8375081-L.jpg",
            //    Description = "A family heads to an isolated hotel for the winter where an evil presence drives the father insane, while his psychic son sees horrific visions of the past and future."
            //});

            //books.Add(new Book
            //{
            //    Title = "Bossypants",
            //    Author = "Tina Fey",
            //    Genre = "Comedy",
            //    Cover = "https://covers.openlibrary.org/b/id/7866235-L.jpg",
            //    Description = "In her hilarious memoir, Tina Fey reflects on her life, career in comedy, and the absurdities of being a woman in show business."
            //});

            //books.Add(new Book
            //{
            //    Title = "Pride and Prejudice",
            //    Author = "Jane Austen",
            //    Genre = "Romance",
            //    Cover = "https://covers.openlibrary.org/b/id/7888800-L.jpg",
            //    Description = "A classic tale of love and misunderstanding, as Elizabeth Bennet navigates societal pressures and her evolving feelings for the wealthy but aloof Mr. Darcy."
            //});

            //books.Add(new Book
            //{
            //    Title = "The Hunger Games",
            //    Author = "Suzanne Collins",
            //    Genre = "Action",
            //    Cover = "https://covers.openlibrary.org/b/id/8164440-L.jpg",
            //    Description = "In a dystopian future, Katniss Everdeen volunteers to take her sister's place in the Hunger Games, a deadly televised competition where participants fight to the death."
            //});

            //books.Add(new Book
            //{
            //    Title = "Dune",
            //    Author = "Frank Herbert",
            //    Genre = "Sci-Fi",
            //    Cover = "https://covers.openlibrary.org/b/id/7984916-L.jpg",
            //    Description = "Set in a distant future amidst a huge interstellar empire, young Paul Atreides embarks on a journey to protect his family and planet, and fulfill his destiny as a messiah figure."
            //});

            //dbContext.Books.AddRange(books);
            //dbContext.SaveChanges();

            //List<Customer> customers = new List<Customer>();

            //customers.Add(new Customer
            //{
            //    FirstName = "John",
            //    LastName = "Doe",
            //    Username = "john123",
            //    Email = "john.doe@example.com",
            //    Password = "Password123",
            //    PhoneNumber = "555-1234",
            //});

            //customers.Add(new Customer
            //{
            //    FirstName = "Sarah",
            //    LastName = "Connor",
            //    Username = "sarahC",
            //    Email = "sarah.connor@example.com",
            //    Password = "Skynet2024",
            //    PhoneNumber = "555-5678",
            //});

            //customers.Add(new Customer
            //{
            //    FirstName = "Michael",
            //    LastName = "Scott",
            //    Username = "michaelS",
            //    Email = "michael.scott@dundermifflin.com",
            //    Password = "DunderMifflin1",
            //    PhoneNumber = "555-7890",
            //});

            //customers.Add(new Customer
            //{
            //    FirstName = "Emily",
            //    LastName = "Blunt",
            //    Username = "emilyB",
            //    Email = "emily.blunt@example.com",
            //    Password = "QuietPlace2021",
            //    PhoneNumber = "555-2468",
            //});

            //customers.Add(new Customer
            //{
            //    FirstName = "Tom",
            //    LastName = "Hanks",
            //    Username = "tomH",
            //    Email = "tom.hanks@example.com",
            //    Password = "ForestGump",
            //    PhoneNumber = "555-1357",
            //});

            //dbContext.Customers.AddRange(customers);
            //dbContext.SaveChanges();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

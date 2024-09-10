using Microsoft.AspNetCore.Mvc;
using Library_Management_System.Models;
using Library_Management_System.Repositories;

namespace Library_Management_System.Controllers
{
    public class TransactionsController : Controller
    {

        protected readonly MyDBContext _context;

        public TransactionsController(MyDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            TransactionRepository repository = new TransactionRepository(_context);
            TransactionsList transactionsList = new TransactionsList(repository);

            var _Transactions = repository.GetAll();

            foreach (Transaction _Transaction in _Transactions)
            {
                Console.WriteLine(_Transaction.Id);
            }
            return View(_Transactions);
        }

    }
}

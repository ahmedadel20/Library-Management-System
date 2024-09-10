using Library_Management_System.Repositories;

namespace Library_Management_System.Models
{

    public class TransactionsList
    {
        protected readonly TransactionRepository _TransactionRepository;

        // Static list of transactions shared among all instances
        public static List<Transaction> Transactions = new List<Transaction>();

        // Public constructor for initializing the repository and adding transactions
        public TransactionsList(TransactionRepository repository)
        {
            _TransactionRepository = repository;

            // Initialize the static transaction list
            if (Transactions.Count == 0)
            {
                Transactions = new List<Transaction>()
            {
                new Transaction { Id = 1, BookId = 5, CustomerId = 15, LoanDate = new DateTime(2023, 9, 1, 14, 0, 0), ReturnDate = new DateTime(2023, 9, 15, 14, 0, 0) },
                new Transaction { Id = 2, BookId = 12, CustomerId = 20, LoanDate = new DateTime(2023, 8, 25, 10, 30, 0), ReturnDate = new DateTime(2023, 9, 8, 10, 30, 0) },
                new Transaction { Id = 3, BookId = 17, CustomerId = 13, LoanDate = new DateTime(2023, 9, 5, 16, 45, 0), ReturnDate = new DateTime(2023, 9, 19, 16, 45, 0) },
                new Transaction { Id = 4, BookId = 3, CustomerId = 7, LoanDate = new DateTime(2023, 8, 20, 9, 0, 0), ReturnDate = new DateTime(2023, 9, 3, 9, 0, 0) },
                new Transaction { Id = 5, BookId = 26, CustomerId = 22, LoanDate = new DateTime(2023, 9, 10, 13, 20, 0), ReturnDate = new DateTime(2023, 9, 24, 13, 20, 0) },
                new Transaction { Id = 6, BookId = 8, CustomerId = 9, LoanDate = new DateTime(2023, 9, 2, 15, 10, 0), ReturnDate = new DateTime(2023, 9, 16, 15, 10, 0) },
                new Transaction { Id = 7, BookId = 11, CustomerId = 14, LoanDate = new DateTime(2023, 8, 22, 11, 0, 0), ReturnDate = new DateTime(2023, 9, 5, 11, 0, 0) },
                new Transaction { Id = 8, BookId = 19, CustomerId = 18, LoanDate = new DateTime(2023, 8, 28, 12, 0, 0), ReturnDate = new DateTime(2023, 9, 11, 12, 0, 0) },
                new Transaction { Id = 9, BookId = 2, CustomerId = 6, LoanDate = new DateTime(2023, 9, 1, 10, 0, 0), ReturnDate = new DateTime(2023, 9, 15, 10, 0, 0) },
                new Transaction { Id = 10, BookId = 15, CustomerId = 25, LoanDate = new DateTime(2023, 9, 3, 11, 15, 0), ReturnDate = new DateTime(2023, 9, 17, 11, 15, 0) }
            };
            }

            // Insert transactions into the database
            _TransactionRepository?.Create(Transactions);
        }
    }

    //public class TransactionsList
    //{

    //    protected readonly TransactionRepository _TransactionRepository;

    //    public TransactionsList(TransactionRepository repository)
    //    {
    //        _TransactionRepository = repository;
    //    }

    //    public static List<Transaction> Transactions = new List<Transaction>();

    //    TransactionsList()
    //    {
    //        Transactions = new List<Transaction>()
    //        {
    //            new Transaction { Id = 1, BookId = 5, CustomerId = 15, LoanDate = new DateTime(2023, 9, 1, 14, 0, 0), ReturnDate = new DateTime(2023, 9, 15, 14, 0, 0) },
    //            new Transaction { Id = 2, BookId = 12, CustomerId = 20, LoanDate = new DateTime(2023, 8, 25, 10, 30, 0), ReturnDate = new DateTime(2023, 9, 8, 10, 30, 0) },
    //            new Transaction { Id = 3, BookId = 17, CustomerId = 13, LoanDate = new DateTime(2023, 9, 5, 16, 45, 0), ReturnDate = new DateTime(2023, 9, 19, 16, 45, 0) },
    //            new Transaction { Id = 4, BookId = 3, CustomerId = 7, LoanDate = new DateTime(2023, 8, 20, 9, 0, 0), ReturnDate = new DateTime(2023, 9, 3, 9, 0, 0) },
    //            new Transaction { Id = 5, BookId = 26, CustomerId = 22, LoanDate = new DateTime(2023, 9, 10, 13, 20, 0), ReturnDate = new DateTime(2023, 9, 24, 13, 20, 0) },
    //            new Transaction { Id = 6, BookId = 8, CustomerId = 9, LoanDate = new DateTime(2023, 9, 2, 15, 10, 0), ReturnDate = new DateTime(2023, 9, 16, 15, 10, 0) },
    //            new Transaction { Id = 7, BookId = 11, CustomerId = 14, LoanDate = new DateTime(2023, 8, 22, 11, 0, 0), ReturnDate = new DateTime(2023, 9, 5, 11, 0, 0) },
    //            new Transaction { Id = 8, BookId = 19, CustomerId = 18, LoanDate = new DateTime(2023, 8, 28, 12, 0, 0), ReturnDate = new DateTime(2023, 9, 11, 12, 0, 0) },
    //            new Transaction { Id = 9, BookId = 2, CustomerId = 6, LoanDate = new DateTime(2023, 9, 1, 10, 0, 0), ReturnDate = new DateTime(2023, 9, 15, 10, 0, 0) },
    //            new Transaction { Id = 10, BookId = 15, CustomerId = 25, LoanDate = new DateTime(2023, 9, 3, 11, 15, 0), ReturnDate = new DateTime(2023, 9, 17, 11, 15, 0) }
    //        };

    //        _TransactionRepository?.Create(Transactions);

    //    }
    //}
}

using Library_Management_System.Models;

namespace Library_Management_System.Repositories
{
    public class TransactionRepository : Repository<Transaction>, ITransactionRepository
    {

        protected readonly MyDBContext _context;

        public TransactionRepository(MyDBContext context) : base(context)
        {
            _context = context;
        }

        public void test()
        {
            throw new NotImplementedException();
        }
    }
}

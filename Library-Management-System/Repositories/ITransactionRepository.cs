using Library_Management_System.Models;

namespace Library_Management_System.Repositories
{
    public interface ITransactionRepository : IRepository<Transaction>
    {
        //IEnumerable<Transaction> GetAllTransaction();
        //Transaction GetTransactionById(int transactionId);
        //Transaction AddTransaction(Transaction transaction);
        //Transaction UpdateTransaction(Transaction transaction);
        //void DeleteTransaction(int transactionId);

        void test();

    }
}

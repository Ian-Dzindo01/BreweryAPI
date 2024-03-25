using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BreweryAPI.Models
{
    public class Transaction
   {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string BreweryName { get; set; }
        public string WholesalerName { get; set; }
        public string BeerName { get; set; }
        public decimal Amount { get; set; }

        public Transaction(int transactionId, DateTime transactionDate, string BreweryName, string WholesalerName, decimal amount)
        {
            TransactionId = transactionId;
            TransactionDate = transactionDate;
            BreweryName = BreweryName;
            WholesalerName = WholesalerName;
            Amount = amount;
        }
    }
}
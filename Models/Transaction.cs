using System;


namespace BreweryAPI.Models
{
    public class Transaction
   {
        public int TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string BuyerName { get; set; }
        public string SellerName { get; set; }
        public decimal Amount { get; set; }

        public Transaction(int transactionId, DateTime transactionDate, string buyerName, string sellerName, decimal amount)
        {
            TransactionId = transactionId;
            TransactionDate = transactionDate;
            BuyerName = buyerName;
            SellerName = sellerName;
            Amount = amount;
        }

        // Additional properties, methods, or validations can be added as needed
    }
}
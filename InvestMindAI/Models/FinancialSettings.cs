
namespace InvestMindAI.Models
{
    public class FinancialSettings
    {
        public int Id { get; set; }

        public decimal StocksValue { get; set; }

        public decimal EtfValue { get; set; }

        public decimal CashValue { get; set; }

        public decimal OtherAssetsValue { get; set; }

        public decimal MonthlyBudget { get; set; }
    }
}
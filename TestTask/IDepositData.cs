using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    public interface IDepositData
    {
        DateTime DateAgreement { get; set; }
        DateTime CalculationDate { get; set; }
        double SummaryDeposit { get; set; }
        double PercentDeposit { get; set; }
        double ReplenishmentDeposit { get; set; }
        TypeCapitalEnum TypeCapital { get; set; }
        bool IsReplenishmentDepositPresented { get; set; }
    }
}

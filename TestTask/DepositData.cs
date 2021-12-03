using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestTask
{
    public class DepositData : IDepositData
    {
        #region Fields

        public DateTime DateAgreement { get; set; }
        public DateTime CalculationDate { get; set; }
        public double SummaryDeposit { get; set; }
        public double PercentDeposit { get; set; }
        public TypeCapitalEnum TypeCapital { get; set; }
        public double ReplenishmentDeposit { get; set; }
        public bool IsReplenishmentDepositPresented { get; set; }

        #endregion // End - Fields

        public DepositData(DateTime dateAgreement, DateTime calculationDate, double summaryDeposit, double percentDeposit, TypeCapitalEnum typeCapital, bool isReplenishmentDepositPresented = false, double replenishmentDeposit = 0)
        {
            DateAgreement = dateAgreement;
            CalculationDate = calculationDate;
            SummaryDeposit = summaryDeposit;
            PercentDeposit = percentDeposit;
            ReplenishmentDeposit = replenishmentDeposit;
            IsReplenishmentDepositPresented = isReplenishmentDepositPresented;
            TypeCapital = typeCapital;
        }

        public double CalculateDeposit
        {
            get
            {
                if (CalculationDate > DateAgreement)
                {
                    return !IsReplenishmentDepositPresented ? CalculateDepositSummaryPercent() : CalculateReplenishmentDepositSummaryPercent();
                }
                else throw new ArgumentException("Error! Calculation Date lower that Date Agreement");
            }
        }

        public double DepositTotalDays
        {
            get
            {
                double _type;
                switch (TypeCapital)
                {
                    case TypeCapitalEnum.Monthly:
                        _type = ((CalculationDate.Year - DateAgreement.Year) * 12) + CalculationDate.Month - DateAgreement.Month;
                        break;
                    case TypeCapitalEnum.Quarterly:
                        _type = (((CalculationDate.Year - DateAgreement.Year) * 12) + CalculationDate.Month - DateAgreement.Month) / 3;
                        break;
                    case TypeCapitalEnum.Daily:
                        _type = (CalculationDate.Date - DateAgreement.Date).TotalDays;
                        break;
                    default:
                        _type = 0;
                        break;
                }

                return _type;
            }
        }

        private double CalculateDepositSummaryPercent() => (SummaryDeposit * Convert.ToDouble(Math.Pow(1 + (PercentDeposit / 100 / (int)TypeCapital), DepositTotalDays))) - SummaryDeposit;

        private double CalculateReplenishmentDepositSummaryPercent()
        {
            double summaryPercent = 0;

            for (int i = 0; i < DepositTotalDays; i++)
            {
                SummaryDeposit += ReplenishmentDeposit;
                summaryPercent += SummaryDeposit * Convert.ToDouble(1 + (PercentDeposit / 100 / (int)TypeCapital)) - SummaryDeposit;
            }

            return summaryPercent;

        }
    }
}

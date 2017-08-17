using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WealthManagement
{
    public class WealthData
    {
        public Dictionary<string, decimal> FixedNegativePositions { get; private set; }

        public Dictionary<string, decimal> FixedPositivePositions { get; private set; }

        public Dictionary<string, decimal> VariableNegativePositions { get; private set; }

        public Dictionary<string, decimal> VariablePositivePositions { get; private set; }

        public Dictionary<string, decimal> SavingsPositions { get; private set; }

        public decimal FixedNegativePositionSum { get; private set; }

        public decimal FixedPositivePositionSum { get; private set; }

        public decimal VariableNegativePositionSum { get; private set; }

        public decimal VariablePositivePositionSum { get; private set; }

        public decimal SavingsPositionsSum { get; private set; }

        public decimal AllPositionSum { get; private set; }

        public Dictionary<string, decimal> CryptoPortfolioNumber { get; private set; }

        public Dictionary<string, decimal> CryptoPortfolioAmount { get; private set; }

        public decimal CryptoPortfolioSum { get; private set; }

        public Dictionary<string, decimal> PreciousMetalsGramm { get; private set; }

        public Dictionary<string, decimal> PreciousMetalsAmount { get; private set; }

        public decimal PreciousMetalsSum { get; private set; }

        public Dictionary<string, decimal> Savings { get; private set; }

        public Dictionary<string, DateTime> SavingsDates { get; private set; }

        public Dictionary<string, decimal> SavingInterests { get; private set; }

        public Dictionary<string, decimal> CalculatedSavings { get; private set; }

        public decimal CalculatedSavingsSum { get; private set; }
        
        public decimal PortfolioSum { get; private set; }





        public void AddFixedNegativePosition(string positionName, decimal amount)
        {
            FixedNegativePositions.Add(positionName, amount);
        }

        public void AddFixedPositivePosition(string positionName, decimal amount)
        {
            FixedPositivePositions.Add(positionName, amount);
        }

        public void RemoveFixedPositivePosition(string positionsName)
        {
            FixedPositivePositions.Remove(positionsName);
        }

        public void RemoveFixedNegativePosition(string positionName)
        {
            FixedNegativePositions.Remove(positionName);
        }

        public void AddVariableNegativePosition(string positionName, decimal amount)
        {
            VariableNegativePositions.Add(positionName, amount);
        }

        public void AddVariablePositivePosition(string positionName, decimal amount)
        {
            VariablePositivePositions.Add(positionName, amount);
        }

        public void RemoveVariablePositivePosition(string positionsName)
        {
            VariablePositivePositions.Remove(positionsName);
        }

        public void RemoveNegativePosition(string positionName)
        {
            VariableNegativePositions.Remove(positionName);
        }

        public void AddSavingsPosition(string positionName, decimal amount)
        {
            SavingsPositions.Add(positionName, amount);
        }

        public void RemoveSavingsPosition(string positionName)
        {
            SavingsPositions.Remove(positionName);
        }

        public void SetFixedNegativePositionSum(decimal amount)
        {
            FixedNegativePositionSum = amount;
        }

        public void SetFixedPositivePositionSum(decimal amount)
        {
            FixedPositivePositionSum = amount;
        }

        public void SetVariableNegativePositionSum(decimal amount)
        {
            VariableNegativePositionSum = amount;
        }

        public void SetVariablePositivePositionSum(decimal amount)
        {
            VariablePositivePositionSum = amount;
        }

        public void SetSavingsPositionSum(decimal amount)
        {
            SavingsPositionsSum = amount;
        }

        public void SetAllPositionSum(decimal amount)
        {
            AllPositionSum = amount;
        }

        public void AddCryptoPortfolioNumber(string cryptoName, decimal number)
        {
            CryptoPortfolioNumber.Add(cryptoName, number);
        }

        public void RemoveCryptoPortfolioNumber(string cryptoName)
        {
            CryptoPortfolioNumber.Remove(cryptoName);
        }

        public void AddCryptoPortfolioAmount(string cryptoName, decimal amount)
        {
            CryptoPortfolioAmount.Add(cryptoName, amount);
        }

        public void RemoveCryptoPortfolioAmount(string cryptoName)
        {
            CryptoPortfolioAmount.Remove(cryptoName);
        }

        public void SetCryptoPortfolioSum(decimal amount)
        {
            CryptoPortfolioSum = amount;
        }

        public void AddPreciousMetalsGramm(string preciousMetalName, int gramm)
        {
            PreciousMetalsGramm.Add(preciousMetalName, gramm);
        }

        public void RemovePreciousMetalsGramm(string preciousMetalName)
        {
            PreciousMetalsGramm.Remove(preciousMetalName);
        }

        public void AddPreciousMetalsAmount(string preciousMetalName, int amount)
        {
            PreciousMetalsAmount.Add(preciousMetalName, amount);
        }

        public void RemovePreciousMetalsAmount(string preciousMetalName)
        {
            PreciousMetalsAmount.Remove(preciousMetalName);
        }

        public void SetPreciousMetalsSum(decimal amount)
        {
            PreciousMetalsSum = amount;
        }

        public void AddSavings(string savingName, decimal amount)
        {
            Savings.Add(savingName, amount);
        }

        public void RemoveSavings(string savingName, decimal amount)
        {
            Savings.Remove(savingName);
        }

        public void AddSavingsDate(string savingName, DateTime date)
        {
            SavingsDates.Add(savingName, date);
        }

        public void RemoveSavingsDate(string savingName)
        {
            SavingsDates.Remove(savingName);
        }

        public void AddSavingInterests(string savingName, decimal interest)
        {
            SavingInterests.Add(savingName, interest);
        }

        public void RemoveSavingsInterests(string savingName)
        {
            SavingInterests.Remove(savingName);
        }

        public void AddCalculatedSavings(string savingName, decimal amount)
        {
            CalculatedSavings.Add(savingName, amount);
        }

        public void RemoveCalculatedSavings(string savingName)
        {
            CalculatedSavings.Remove(savingName);
        }

        public void SetCalculatedSavingsSum(decimal amount)
        {
            CalculatedSavingsSum = amount;
        }

        public void SetPortfolioSum(decimal amount)
        {
            PortfolioSum = amount;
        }
    }
}

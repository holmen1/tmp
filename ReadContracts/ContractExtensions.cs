using ReadContracts.Models;

namespace ReadContracts;

public static class ContractExtensions
{
    public static double CalculateAverageAge(this List<Contract> contracts)
    {
        if (!contracts.Any())
            return 0;

        var totalAge = contracts.Sum(contract => (contract.Date - contract.BirthDate).TotalDays / 365.25);
        return totalAge / contracts.Count;
    }

    public static decimal CalculateTotalValue(this List<Contract> contracts)
    {
        if (!contracts.Any())
            return 0;

        return contracts.Sum(contract => contract.Value);
    }
}
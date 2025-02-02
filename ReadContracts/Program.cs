using System.Globalization;
using CsvHelper;
using ReadContracts.Models;

namespace ReadContracts;

internal static class Program
{
    private static void Main()
    {
        var filePath = "/Users/holmen/repos/ReadContracts/ReadContracts/Input/sample.csv";
        List<Contract> contracts;

        using (var reader = new StreamReader(filePath))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            contracts = csv.GetRecords<Contract>().ToList();
        }

        // Output the contracts to verify
        foreach (var contract in contracts)
            Console.WriteLine($"ID: {contract.ContractId}, Type: {contract.Type}, Value: {contract.Value}");

        var averageAge = contracts.CalculateAverageAge();
        var totalValue = contracts.CalculateTotalValue();

        Console.WriteLine($"Average Age: {averageAge}");
        Console.WriteLine($"Total Value: {totalValue}");
    }
}
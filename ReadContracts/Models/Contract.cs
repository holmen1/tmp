using CsvHelper.Configuration.Attributes;

namespace ReadContracts.Models;

public class Contract
{
    [Name("date")] public DateTime Date { get; set; }

    [Name("contract")] public int ContractId { get; set; }

    [Name("type")] public string Type { get; set; }

    [Name("value")] public decimal Value { get; set; }

    [Name("birthdate")] public DateTime BirthDate { get; set; }

    [Name("vestingdate")] public DateTime VestingDate { get; set; }
}
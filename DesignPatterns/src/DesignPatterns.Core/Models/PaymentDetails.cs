namespace DesignPatterns.Core.Models;

public class PaymentDetails
{
    public decimal Amount { get; set; }
    public string Currency { get; set; } = "USD";
    public string Description { get; set; } = string.Empty;
}
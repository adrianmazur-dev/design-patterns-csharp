using DesignPatterns.Behavioral.Strategy.Interfaces;
using DesignPatterns.Core.Models;

namespace DesignPatterns.Behavioral.Strategy.Implementations;

public class CreditCardPaymentStrategy : IPaymentStrategy
{
    public async Task<PaymentResult> ProcessPaymentAsync(PaymentDetails paymentDetails)
    {
        // Simulate API call to payment gateway
        await Task.Delay(1000);

        return new PaymentResult
        {
            Success = true,
            TransactionId = $"CC-{Guid.NewGuid()}",
            Message = "Credit card payment processed successfully",
            TransactionDate = DateTime.UtcNow
        };
    }

    public bool ValidatePaymentDetails(PaymentDetails paymentDetails)
    {
        if (paymentDetails.Amount <= 0)
            return false;

        if (string.IsNullOrEmpty(paymentDetails.Currency))
            return false;

        return true;
    }
}
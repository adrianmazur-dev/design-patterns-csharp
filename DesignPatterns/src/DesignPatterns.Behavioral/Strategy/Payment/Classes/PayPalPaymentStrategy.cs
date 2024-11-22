using DesignPatterns.Behavioral.Strategy.Payment.Interfaces;
using DesignPatterns.Core.Models;

namespace DesignPatterns.Behavioral.Strategy.Payment.Classes;

public class PayPalPaymentStrategy : IPaymentStrategy
{
    public async Task<PaymentResult> ProcessPaymentAsync(PaymentDetails paymentDetails)
    {
        await Task.Delay(2000);

        return new PaymentResult
        {
            Success = true,
            TransactionId = $"PP-{Guid.NewGuid()}",
            Message = "PayPal payment processed successfully",
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
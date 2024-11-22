using DesignPatterns.Behavioral.Strategy.Payment.Interfaces;
using DesignPatterns.Core.Models;

namespace DesignPatterns.Behavioral.Strategy.Payment.Classes;

public class CryptoPaymentStrategy : IPaymentStrategy
{
    public async Task<PaymentResult> ProcessPaymentAsync(PaymentDetails paymentDetails)
    {
        await Task.Delay(3000);

        return new PaymentResult
        {
            Success = true,
            TransactionId = $"CRYPTO-{Guid.NewGuid()}",
            Message = "Crypto payment processed successfully",
            TransactionDate = DateTime.UtcNow
        };
    }

    public bool ValidatePaymentDetails(PaymentDetails paymentDetails)
    {
        if (paymentDetails.Amount <= 0)
            return false;

        if (paymentDetails.Currency != "BTC" && paymentDetails.Currency != "ETH")
            return false;

        return true;
    }
}
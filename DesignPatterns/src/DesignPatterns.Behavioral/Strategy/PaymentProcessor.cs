using DesignPatterns.Behavioral.Strategy.Interfaces;
using DesignPatterns.Core.Models;

namespace DesignPatterns.Behavioral.Strategy;

public class PaymentProcessor
{
    private IPaymentStrategy _paymentStrategy;

    public PaymentProcessor(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public async Task<PaymentResult> ProcessPaymentAsync(PaymentDetails paymentDetails)
    {
        if (!_paymentStrategy.ValidatePaymentDetails(paymentDetails))
        {
            return new PaymentResult
            {
                Success = false,
                Message = "Invalid payment details",
                TransactionDate = DateTime.UtcNow
            };
        }

        return await _paymentStrategy.ProcessPaymentAsync(paymentDetails);
    }
}
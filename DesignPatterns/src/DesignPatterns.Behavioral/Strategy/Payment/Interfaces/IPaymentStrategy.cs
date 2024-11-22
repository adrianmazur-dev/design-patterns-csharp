using DesignPatterns.Core.Models;

namespace DesignPatterns.Behavioral.Strategy.Payment.Interfaces;

public interface IPaymentStrategy
{
    Task<PaymentResult> ProcessPaymentAsync(PaymentDetails paymentDetails);
    bool ValidatePaymentDetails(PaymentDetails paymentDetails);
}
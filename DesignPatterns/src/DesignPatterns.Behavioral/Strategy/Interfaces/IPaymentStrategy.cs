using DesignPatterns.Core.Models;

namespace DesignPatterns.Behavioral.Strategy.Interfaces;

public interface IPaymentStrategy
{
    Task<PaymentResult> ProcessPaymentAsync(PaymentDetails paymentDetails);
    bool ValidatePaymentDetails(PaymentDetails paymentDetails);
}
using DesignPatterns.Behavioral.Strategy.Payment;
using DesignPatterns.Behavioral.Strategy.Payment.Classes;
using DesignPatterns.Core.Models;

namespace DesignPatterns.Console.Examples;

public class StrategyPatternExample
{
    public async Task RunExample()
    {
        System.Console.WriteLine("Strategy Pattern Example - Payment Processing\n");

        var paymentProcessor = new PaymentProcessor(new CreditCardPaymentStrategy());
        var paymentDetails = new PaymentDetails
        {
            Amount = 100.00m,
            Currency = "USD",
            Description = "Test purchase"
        };

        // Process with Credit Card
        System.Console.WriteLine("Processing Credit Card payment...");
        var ccResult = await paymentProcessor.ProcessPaymentAsync(paymentDetails);
        System.Console.WriteLine($"Result: {ccResult.Message}");
        System.Console.WriteLine($"Transaction ID: {ccResult.TransactionId}\n");

        // Switch to PayPal
        paymentProcessor.SetPaymentStrategy(new PayPalPaymentStrategy());
        System.Console.WriteLine("Processing PayPal payment...");
        var ppResult = await paymentProcessor.ProcessPaymentAsync(paymentDetails);
        System.Console.WriteLine($"Result: {ppResult.Message}");
        System.Console.WriteLine($"Transaction ID: {ppResult.TransactionId}\n");

        // Switch to Crypto
        paymentProcessor.SetPaymentStrategy(new CryptoPaymentStrategy());
        paymentDetails.Currency = "BTC";
        System.Console.WriteLine("Processing Crypto payment...");
        var cryptoResult = await paymentProcessor.ProcessPaymentAsync(paymentDetails);
        System.Console.WriteLine($"Result: {cryptoResult.Message}");
        System.Console.WriteLine($"Transaction ID: {cryptoResult.TransactionId}");
    }
}
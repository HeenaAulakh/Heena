using System;
using PaymentProcessingApplication.Model;

namespace PaymentProcessingApplication.BusinessRules
{
   class CommissionPaymentHandler : BasePaymentProcessingHandler
   {
      protected override bool CanProcess(Payment payment)
      {
         return payment.ProductType == "Physical" || payment.ProductType == "Book";
      }

      protected override void Process(Payment payment)
      {
         Console.WriteLine("Generate commision payment to the agent");

      }
   }
}

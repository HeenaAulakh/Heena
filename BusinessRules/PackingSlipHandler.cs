using System;
using System.Collections.Generic;
using System.Text;
using PaymentProcessingApplication.Model;

namespace PaymentProcessingApplication.BusinessRules
{
   class PackingSlipHandler : BasePaymentProcessingHandler
   {
      protected override bool CanProcess(Payment payment)
      {
         return payment.ProductType == "Physical";
      }

      protected override void Process(Payment payment)
      {
         Console.WriteLine("Generate packing slip");
         
      }
   }
}

using PaymentProcessingApplication.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessingApplication.BusinessRules
{
   class PackingSlipFOrRoyalityDepartment : BasePaymentProcessingHandler
   {
      protected override bool CanProcess(Payment payment)
      {
         return payment.ProductType == "Book";
      }

      protected override void Process(Payment payment)
      {
         Console.WriteLine("Generate duplicate packing slip for royality department");
        
      }
   }
}

using System;
using System.Collections.Generic;
using System.Text;
using PaymentProcessingApplication.Model;

namespace PaymentProcessingApplication.BusinessRules
{
   class MembershipHandler : BasePaymentProcessingHandler
   {
      protected override bool CanProcess(Payment payment)
      {
         return payment.ProductType == "Membership";
      }
      protected override void Process(Payment payment)
      {
         Console.WriteLine("Activate membership account");
      }  
   }
}

using PaymentProcessingApplication.BusinessRules;
using PaymentProcessingApplication.Model;
using System;

namespace PaymentProcessingApplication
{
   class Program
   {
      static void Main(string[] args)
      {
         BasePaymentProcessingHandler baseHandler = new PackingSlipHandler();
         BasePaymentProcessingHandler membershipHandler = new MembershipHandler();
         BasePaymentProcessingHandler duplicateSlipHandler = new PackingSlipFOrRoyalityDepartment();
         
         baseHandler.setNextHandler(duplicateSlipHandler);
         duplicateSlipHandler.setNextHandler(membershipHandler);
         membershipHandler.setNextHandler(new CommissionPaymentHandler());
         Payment payment = new Payment()
         {
            ProductType = "Physical"
         };

         //calling chain of responsibility 
         baseHandler.ProcessPayment(payment);


         Console.ReadKey();
      }
   }
}

using PaymentProcessingApplication.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessingApplication.BusinessRules
{
   public abstract class BasePaymentProcessingHandler
   {
      private BasePaymentProcessingHandler NextHandler;

      public void setNextHandler(BasePaymentProcessingHandler NextHandler)
      {
         this.NextHandler = NextHandler;
      }      
      public void ProcessPayment(Payment payment)
      {
         if(CanProcess(payment))
            Process(payment);
         if (NextHandler != null)
            NextHandler.ProcessPayment(payment);
      }

      protected abstract bool CanProcess(Payment payment);
      protected abstract void Process(Payment payment);
   }
}

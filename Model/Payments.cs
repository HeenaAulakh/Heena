using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessingApplication.Model
{
   public class Payment
   {
      public decimal Amount { get; set; }
      public string ProductType { get; set; }
      public string Reference { get; set; }
   }
}

using System;
using Balta.SharedContext;

namespace Balta.SubscriptionContext{
    public class Subscription : Base{
        public Plan Paln { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsInactive => EndDate <= DateTime.Now;
    }
}
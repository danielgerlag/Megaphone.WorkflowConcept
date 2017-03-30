using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace Megaphone.WorkflowConcept.Steps
{
    public class CallWishlist : StepBody
    {
        public string[] Products { get; set; }

        public int WishlistId { get; set; }

        public override ExecutionResult Run(IStepExecutionContext context)
        {
            //this step class can be registered with an IoC container
            //to have any required dependencies injected in
            Console.WriteLine("Calling Wishlist");
            WishlistId = 1001;
            return ExecutionResult.Next();
        }
    }
}

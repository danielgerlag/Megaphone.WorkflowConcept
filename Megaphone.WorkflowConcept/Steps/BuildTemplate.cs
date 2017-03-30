using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace Megaphone.WorkflowConcept.Steps
{
    public class BuildTemplate : StepBody
    {
        public string CustomerInfo { get; set; }

        public int WishlistId { get; set; }

        public string Html { get; set; }

        public override ExecutionResult Run(IStepExecutionContext context)
        {
            Console.WriteLine("Calling template service");
            Html = @"<p>Hi</p>";
            return ExecutionResult.Next();
        }
    }
}

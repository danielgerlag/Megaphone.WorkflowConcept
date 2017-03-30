using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace Megaphone.WorkflowConcept.Steps
{
    public class EnqueueEmail : StepBody
    {
        public string CustomerInfo { get; set; }

        public string Html { get; set; }

        public override ExecutionResult Run(IStepExecutionContext context)
        {
            Console.WriteLine("Enqueuing email");
            return ExecutionResult.Next();
        }
    }
}

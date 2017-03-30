using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Megaphone.WorkflowConcept.Steps;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace Megaphone.WorkflowConcept
{
    public class ReceiptWorkflow : IWorkflow<ReceiptData>
    {
        public string Id => "Megaphone.Receipt";
        public int Version => 1;

        public void Build(IWorkflowBuilder<ReceiptData> builder)
        {
            builder
                .StartWith<CallWishlist>()
                    .Input(step => step.Products, data => data.Products)
                    .Output(data => data.WishlistId, step => step.WishlistId)
                    .OnError(WorkflowErrorHandling.Retry, TimeSpan.FromSeconds(10))
                .Then<BuildTemplate>()
                    .Input(step => step.CustomerInfo, data => data.CustomerInfo)
                    .Input(step => step.WishlistId, data => data.WishlistId)
                    .Output(data => data.ReceiptHtml, step => step.Html)
                    .OnError(WorkflowErrorHandling.Retry, TimeSpan.FromSeconds(10))
                .Then<EnqueueEmail>()
                    .Input(step => step.CustomerInfo, data => data.CustomerInfo)
                    .Input(step => step.Html, data => data.ReceiptHtml)
                    .OnError(WorkflowErrorHandling.Retry, TimeSpan.FromSeconds(10));

            //workflow library can be enhanced to support more complex retry strategies
        }
    }
}

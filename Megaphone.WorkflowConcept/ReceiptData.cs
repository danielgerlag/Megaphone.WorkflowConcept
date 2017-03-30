using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megaphone.WorkflowConcept
{
    public class ReceiptData
    {
        public string[] Products { get; set; }

        public int WishlistId { get; set; }

        public string CustomerInfo { get; set; }

        public string ReceiptHtml { get; set; }
    }
}

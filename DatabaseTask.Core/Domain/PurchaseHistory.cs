using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class PurchaseHistory
    {
        [Key]
        public Guid PurchaseHistoryId { get; set; }
        public Guid ClientId { get; set; }
        public Guid ProductId { get; set; }
        public int Count { get; set; }

    }
}

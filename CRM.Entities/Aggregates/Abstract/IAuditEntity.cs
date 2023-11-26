using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Entities.Aggregates.Abstract
{
    public interface IAuditEntity
    {
        public DateTime? CreationTime { get; }
        public Guid? CreatorId { get; }
        public DateTime? LastModificationTime { get; }
        public Guid? LastModifierId { get; }
    }
}

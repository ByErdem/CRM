using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Entities.Aggregates.Abstract
{
    public interface IFullAuditEntity : IAuditEntity
    {
        public Guid? DeleterId { get; }

        public DateTime? DeletionTime { get; }
    }
}

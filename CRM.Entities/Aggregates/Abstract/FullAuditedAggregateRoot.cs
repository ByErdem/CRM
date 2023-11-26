using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Entities.Aggregates.Abstract
{

    public abstract class FullAuditedAggregateRoot : FullAuditedAggregateRoot<Guid>
    {

    }
    public abstract class FullAuditedAggregateRoot<TKey> : AggregateRoot<TKey>, IFullAuditEntity where TKey : IComparable, IComparable<TKey>, IEquatable<TKey>, ISpanFormattable
    {
        public virtual DateTime? CreationTime { get; protected set; }
        public virtual Guid? CreatorId { get; protected set; }
        public virtual DateTime? LastModificationTime { get; protected set; }
        public virtual Guid? LastModifierId { get; protected set; }
        public virtual Guid? DeleterId { get; protected set; }
        public virtual DateTime? DeletionTime { get; protected set; }

        protected FullAuditedAggregateRoot()
        {

        }
    }
}

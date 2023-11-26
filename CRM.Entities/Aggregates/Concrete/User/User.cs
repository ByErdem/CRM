namespace CRM.Entities.Aggregates.Concrete.User
{
    public class User
    {
        public string Id { get; protected set; }
        public string UserName { get; protected set; }
        public string? NormalizedUserName { get; protected set; }
        public string? Email { get; protected set; }
        public string? NormalizedEmail { get; protected set; }
        public bool? EmailConfirmed { get; protected set; }
        public string? PasswordHash { get; protected set; }
        public string? PhoneNumber { get; protected set; }
        public bool? PhoneNumberConfirmed { get; protected set; }
        public bool? TwoFactorEnabled { get; protected set; }
        public DateTime? LockoutEnd { get; protected set; }
        public bool? LockoutEnabled { get; protected set; }
        public int? AccessFailedCount { get; protected set; }
        public ICollection<UserDetail> UserClaims { get; protected set; } = new List<UserDetail>();
    }
}

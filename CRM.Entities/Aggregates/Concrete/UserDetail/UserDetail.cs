using System.ComponentModel.DataAnnotations;

namespace CRM.Entities.Aggregates.Concrete.UserDetail
{
    public class UserDetail : FullAuditedEntity
    {
        [Required]
        public int UserId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        [MaxLength(50)]
        public string PlaceOfBirth { get; set; }
        public int? PlaceOFBirthCountryId { get; set; }
        [MaxLength(20)]
        public string PhoneWork { get; set; }
        [MaxLength(20)]
        public string PhonePersonel { get; set; }
        [MaxLength(250)]
        public string EmailPersonal { get; set; }
        [MaxLength(250)]
        public string Address { get; set; }
        [MaxLength(11)]
        public string TCKN { get; set; }
        [MaxLength(50)]
        public string IdentityNo { get; set; }
        [MaxLength(20)]
        public string PassportNo { get; set; }
        public int WorkStatusId { get; set; }
        public DateTime? WorkingSince { get; set; }
        public DateTime? LeavingDate { get; set; }
        [MaxLength(10)]
        public string BloodType { get; set; }
        [MaxLength(50)]
        public string Avatar { get; set; }
        public int? ManagerId { get; set; }
        [MaxLength(500)]
        public string Note { get; set; }
        public int? GenderId { get; set; }
        public int? NationalityId { get; set; }
        public string Language { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public int CreatedBy { get; set; }
    }
}

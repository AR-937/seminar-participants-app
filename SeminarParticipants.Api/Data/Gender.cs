using System.ComponentModel.DataAnnotations;

namespace SeminarParticipants.Api.Data
{
    public class Gender : BaseEntity
    {
        [StringLength(50)]
        public string Name { get; set; } = null!;
    }
}
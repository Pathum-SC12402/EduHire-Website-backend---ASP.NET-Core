using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.model
{
    public class TeacherData
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Age { get; set; }
        public required string Gender { get; set; }
        public required string Address { get; set; }
        public required string SpecializedArea { get; set; }
        public required string TeachingSide { get; set; }
        public string CV { get; set; } = string.Empty;
        public string ProfilePicture { get; set; } = string.Empty;
        public string CoverPicture { get; set; } = string.Empty;
        public required string Description { get; set; }
        public int TeacherAccountId { get; set; }
        public required TeacherAccount TeacherAccount { get; set; } = null!;
        public List<TeacherCertificates> Certificates { get; set; } = new List<TeacherCertificates>();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.model.teacherModels
{
    public class TeacherData
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Age { get; set; }
        public string? Gender { get; set; }
        public string? Address { get; set; }
        public string? SpecializedArea { get; set; }
        public string? TeachingSide { get; set; }
        public string CVUrl { get; set; } = string.Empty;
        public string ProfilePictureUrl { get; set; } = string.Empty;
        public string CoverPictureUrl { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int TeacherAccountId { get; set; }
        public TeacherAccount? TeacherAccount { get; set; }
        public List<TeacherCertificates> Certificates { get; set; } = new List<TeacherCertificates>();
    }
}
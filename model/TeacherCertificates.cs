using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.model
{
    public class TeacherCertificates
    {
        public int Id { get; set; }
        public required string CertificateName { get; set; }
        public required string CertificateUrl { get; set; }
        public int TeacherDataId { get; set; }
        public required TeacherData TeacherData { get; set; } = null!;
    }
}
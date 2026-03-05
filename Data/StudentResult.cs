using Microsoft.AspNetCore.Mvc;

namespace LoadTestingAPI.Data
{
    public class StudentResult
    {
        public int RollNumber { get; set; }
        public string StudentFullName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Faculty { get; set; }
        public string CollegeName { get; set; }
        public int TotalMarks { get; set; }
        public string Division { get; set; }

        public List<SubjectResult> Subjects { get; set; }
    }
}

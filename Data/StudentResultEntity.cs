namespace LoadTestingAPI.Data
{
    public class StudentResultEntity
    {
        public string? RollNumber { get; set; }
        public string? RegistrationNo { get; set; }
        public string? StudentFullName { get; set; }
        public string? FatherName { get; set; }
        public string? MotherName { get; set; }
        public string? Faculty { get; set; }
        public string? CollegeName { get; set; }
        public int?   TotalMarks { get; set; }
        public string? Division { get; set; }

        public string? SubjectPaperName { get; set; }
        public int? ObtainedMarks { get; set; }
        public string? SubjectTotal { get; set; }
    }
}

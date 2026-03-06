using Microsoft.EntityFrameworkCore;

namespace LoadTestingAPI.Data
{
    public class DbHelper
    {
        private readonly AppDbContext _context;

        public DbHelper(AppDbContext context)
        {
            _context = context;
        }

        //public List<StudentResult> GetStudentResult(string rollNumber)
        public List<StudentResult> GetStudentResult(string RegistrationNo)
        {
            var data = _context.FinalPublishedResults.AsNoTracking().Where(x => x.RegistrationNo == RegistrationNo).ToList();
            //var data = _context.FinalPublishedResults.AsNoTracking().Where(x => x.RollNumber == rollNumber).ToList();

            var results = data
                .GroupBy(x => new
                {
                    x.RollNumber,
                    x.RegistrationNo,
                    x.StudentFullName,
                    x.FatherName,
                    x.MotherName,
                    x.Faculty,
                    x.CollegeName,
                    x.TotalMarks,
                    x.Division
                })
                .Select(g => new StudentResult
                {
                    RollNumber = g.Key.RollNumber,
                    RegistrationNo = g.Key.RegistrationNo,
                    StudentFullName = g.Key.StudentFullName,
                    FatherName = g.Key.FatherName,
                    MotherName = g.Key.MotherName,
                    Faculty = g.Key.Faculty,
                    CollegeName = g.Key.CollegeName,
                    TotalMarks = g.Key.TotalMarks,
                    Division = g.Key.Division,

                    Subjects = g.Select(x => new SubjectResult
                    {
                        SubjectPaperName = x.SubjectPaperName,
                        ObtainedMarks = x.ObtainedMarks,
                        SubjectTotal = x.SubjectTotal
                    }).ToList()
                }).ToList();

            return results;
        }
    }
}
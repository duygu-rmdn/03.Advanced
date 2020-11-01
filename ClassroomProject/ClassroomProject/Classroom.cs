using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> data;
        public Classroom(int capacity)
        {
            Capacity = capacity;
            data = new List<Student>();
        }
        public int Capacity { get; set; }
        public int Count { get { return data.Count; } }


        public string RegisterStudent(Student student)
        {
            if (Capacity > data.Count)
            {
                data.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            return "No seats in the classroom".ToString();
        }
        public string DismissStudent(string firstName, string lastName)
        {
            Student toRemove = data.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
            if (toRemove != null)
            {
                data.Remove(toRemove);
                return $"Dismissed student {firstName} {lastName}";
            }
            return "Student not found";
        }
        public string GetSubjectInfo(string subject)
        {
            StringBuilder result = new StringBuilder();
            List<string> studentsToReturn = new List<string>();
            result.AppendLine($"Subject: {subject}");
            result.AppendLine("Students:");
            foreach (var item in data)
            {
                if (item.Subject == subject)
                {
                    studentsToReturn.Add(item.FirstName + " " + item.LastName);
                    result.AppendLine(item.FirstName + " " + item.LastName);
                }
            }
            if (studentsToReturn.Count == 0)
            {
                return "No students enrolled for the subject";
            }
            return result.ToString().TrimEnd();
            
        }
        public int GetStudentsCount()
        {
            return Count;
        }
        public Student GetStudent(string firstName, string lastName)
        {
            Student student = data.FirstOrDefault(c => c.FirstName == firstName && c.LastName == lastName);
            return student;
        }

    }
}

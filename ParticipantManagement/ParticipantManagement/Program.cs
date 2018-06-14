using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticipantManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Participant part = new Participant();

            part.FirstName = "Lisa";
            part.LastName = "Hare";
            part.EmailAddress = "hare.lisa@gmail.com";
            part.StreetAddress1 = "16225 NE 107th Ct.";
            part.City = "Redmond";
            part.State = "WA";
            part.ZipCode = 98052;
            part.LearnedToCode = CodeEducation.College;
            part.HighestEducation = Education.Bachelors;

            Console.WriteLine($"UserID: {part.UserId}, CD: {part.DateCreated}, Name: { part.FirstName} {part.LastName}, Email: " +
                $"{part.EmailAddress}, Address: {part.StreetAddress1}, {part.City}, {part.State}, {part.ZipCode}, Education: {part.HighestEducation}," +
                $"Learned To Code: {part.LearnedToCode}");

            Workshop ws = new Workshop();

            ws.Title = "Technical Interviews";
            ws.Description = "Technical interview and whiteboarding practice. Includes systems design, whiteboarding practice, and practical tips.";
            ws.Length = 180;
            ws.MaterialsLink = "https://drive.google.com/drive/u/0/folders/0BwDeAh-EZLUTSjNfM19tUy1vZWs";

            Console.WriteLine($"Workshop ID: {ws.WorkshopId}, Title: {ws.Title}, Desc: {ws.Description}, Length: {ws.Length}; Materials: {ws.MaterialsLink}");

            Location location = new Location();
            location.addLocation("Industrious", "2003 6th Avenue", "Seattle", "WA", 98021);

            //Session session = new Session(1, "6/10/18", "6:00 pm", 1);

            //Console.WriteLine($"SessionID: {session.SessionId}, Date: {session.Date}, Time: {session.Time}");
            Console.Read();
        }
    }
}

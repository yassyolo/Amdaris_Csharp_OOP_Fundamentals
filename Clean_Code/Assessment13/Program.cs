using Assessment13.Entities;
using Assessment13.Enums;
using Assessment13.Repositories;
using Assessment13.Repository;

class Program
{
    static void Main(string[] args)
    {
        var speaker = new Speaker("Yoana", "Yotova", "yyotova@tu-sofia.bg", 11, true, "https://yassyolo.com",
            new WebBrowser(BrowserName.Chrome.ToString(), 90),
            new List<string> { "Softuni Basics", "Softuni Fundamentals", "Softuni Advanced", "Softuni Web" }, "Microsoft",
            sessions: new List<Session>
            {
                new Session("C# basics", "Learn how to code."),
                new Session("ASP.Net 101", "Learn how to do web applications.")
            });

        try
        {
            IRepository repository = new Repository();
            int? id = speaker.Register(repository);
            Console.WriteLine($"Speaker with id: {id} registered successfully.");
            Console.WriteLine($"Info about speaker {speaker.FirstName} {speaker.LastName}: (email){speaker.Email}, (experience in years){speaker.Experience}, (blog){speaker.BlogUrl}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Registration failed: {ex.Message}");
        }
    }
}

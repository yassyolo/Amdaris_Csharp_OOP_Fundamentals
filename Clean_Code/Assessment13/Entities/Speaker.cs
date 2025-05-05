using Assessment13.Enums;
using Assessment13.Exceptions;
using Assessment13.Repositories;
using static Assessment13.Constants.RequirementConstants;

namespace Assessment13.Entities;

public class Speaker
{
    private static readonly List<string> ObsoleteTechnologies = new() { "Cobol", "Punch Cards", "Commodore", "VBScript" };
    private static readonly List<string> BadDomains = new() { "aol.com", "hotmail.com", "prodigy.com", "CompuServe.com" };
    private static readonly List<string> Employers = new() { "Microsoft", "Google", "Fog Creek Software", "37Signals" };

    public string FirstName { get; }
    public string LastName { get; }
    public string Email { get; }
    public int? Experience { get; }
    public bool HasBlog { get; }
    public string BlogUrl { get; }
    public WebBrowser Browser { get; }
    public List<string> Certifications { get; }
    public string Employer { get; }
    public List<Session> Sessions { get; }
    public int RegistrationFee { get; private set; }

    public Speaker(string firstName, string lastName, string email, int? experience, bool hasBlog, string blogUrl,
                   WebBrowser browser, List<string> certifications, string employer, List<Session> sessions)
    {
        FirstName = firstName ?? throw new ArgumentNullException($"{nameof(FirstName)} is required");
        LastName = lastName ?? throw new ArgumentNullException($"{nameof(LastName)} is required");
        Email = email ?? throw new ArgumentNullException($"{nameof(Email)} is required");
        Experience = experience;
        HasBlog = hasBlog;
        BlogUrl = blogUrl;
        Browser = browser;
        Certifications = certifications;
        Employer = employer;
        Sessions = sessions ?? throw new NoSessionsApprovedException("No sessions approved.");
    }

    public int? Register(IRepository repository)
    {
        if (!MeetsRequirements())
            throw new SpeakerDoesNotMeetRequirementsException("Speaker doesn't meet our abitrary and capricious standards.");

        if (!HasValidSessions())
            throw new NoSessionsApprovedException("Can't register speaker with no sessions to present.");

        CalculateRegistrationFee();
        return repository.SaveSpeaker(this);
    }

    private bool MeetsRequirements()
    {
        bool isQualified = Experience > MinimumExperience || HasBlog || Certifications.Count > CertificationCount || Employers.Contains(Employer);

        if (!isQualified)
        {
            string domain = Email.Split('@').Last();
            isQualified = !BadDomains.Contains(domain) &&
                          !(Browser.Name == BrowserName.InternetExplorer && Browser.MajorVersion < MinimumBrowserMajorVersion);
        }

        return isQualified;
    }

    private bool HasValidSessions()
    {
        bool hasApprovedSession = false;

        foreach (var session in Sessions)
        {
            session.Approved = !ObsoleteTechnologies.Any(tech => session.Title.Contains(tech) || session.Description.Contains(tech));
            if (session.Approved)
            {
                hasApprovedSession = true;
            }
        }

        return hasApprovedSession;
    }

    private void CalculateRegistrationFee()
    {
        RegistrationFee = Experience switch
        {
            1 => 500,
            3 => 250,
            5 => 100,
            9 => 50,
            _ => 0
        };
    }
}


namespace Assessment13.Exceptions;

public class SpeakerDoesNotMeetRequirementsException : Exception
{
    public SpeakerDoesNotMeetRequirementsException(string message)
        : base(message)
    {
    }

    public SpeakerDoesNotMeetRequirementsException(string format, params object[] args)
        : base(string.Format(format, args)) { }
}

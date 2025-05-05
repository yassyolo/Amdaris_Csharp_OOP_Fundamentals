using Assessment13.Entities;
using Assessment13.Repositories;

namespace Assessment13.Repository;

public class Repository : IRepository
{
    private readonly List<Speaker> _speakers = new List<Speaker>();

    public int SaveSpeaker(Speaker speaker)
    {
        _speakers.Add(speaker);
        return _speakers.Count; 
    }
}

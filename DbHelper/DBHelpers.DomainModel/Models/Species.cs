public class Species
{
    public long Id { get; set; }

    public Guid SpeciesKey { get; set; }

    public long PracticeId { get; set; }

    public string SpeciesName { get; set; }

    public DateTime CreatedDate { get; set; }

    public long CreatedByUserId { get; set; }

    public DateTime ModifiedDate { get; set; }

    public long ModifiedByUserId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsStub { get; set; }
}
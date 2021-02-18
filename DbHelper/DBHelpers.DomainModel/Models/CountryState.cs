public class CountryState
{
    public long Id { get; set; }

    public string StateName { get; set; }

    public Guid StateKey { get; set; }

    public long CountryId { get; set; }

    public DateTime CreatedDate { get; set; }

    public long CreatedByUserId { get; set; }

    public DateTime ModifiedDate { get; set; }

    public long ModifiedByUserId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsStub { get; set; }
}
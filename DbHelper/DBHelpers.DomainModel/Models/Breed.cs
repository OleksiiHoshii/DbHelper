public class Breed
{
    public long Id { get; set; }

    public Guid BreedKey { get; set; }

    public long SpeciesId { get; set; }

    public string BreedName { get; set; }

    public DateTime CreatedDate { get; set; }

    public long CreatedByUserId { get; set; }

    public DateTime ModifiedDate { get; set; }

    public long ModifiedByUserId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsStub { get; set; }
}
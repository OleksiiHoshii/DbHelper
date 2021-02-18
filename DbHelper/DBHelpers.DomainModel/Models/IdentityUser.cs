public class IdentityUser
{
    public long Id { get; set; }

    public Guid IdentityUserKey { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsStub { get; set; }
}
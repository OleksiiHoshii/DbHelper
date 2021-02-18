public class Address
{
    public long Id { get; set; }

    public Guid AddressKey { get; set; }

    public long CountryId { get; set; }

    public long? CountryStateId { get; set; }

    public int AddressTypeCode { get; set; }

    public string Line1 { get; set; }

    public string Line2 { get; set; }

    public string Line3 { get; set; }

    public string City { get; set; }

    public string StateOrProvince { get; set; }

    public string PostalCode { get; set; }

    public string Country { get; set; }

    public DateTime CreatedDate { get; set; }

    public long CreatedByUserId { get; set; }

    public DateTime ModifiedDate { get; set; }

    public long ModifiedByUserId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsStub { get; set; }
}
public class MeasurementUnit
{
    public long Id { get; set; }

    public Guid UnitKey { get; set; }

    public int UnitType { get; set; }

    public string UnitValue { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public long CreatedByUserId { get; set; }

    public long ModifiedByUserId { get; set; }

    public bool IsStub { get; set; }
}
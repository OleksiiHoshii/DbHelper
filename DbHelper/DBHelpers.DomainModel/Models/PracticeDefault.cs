public class PracticeDefault
{
    public long Id { get; set; }

    public long? PracticeId { get; set; }

    public long? ProviderId { get; set; }

    public long? SpeciesId { get; set; }

    public long? SexId { get; set; }

    public long WeightUnitId { get; set; }

    public long TemperatureUnitId { get; set; }

    public long TemperatureRouteId { get; set; }

    public long? ProductCategoryId { get; set; }

    public long? ServiceCategoryId { get; set; }

    public long? LabCategoryId { get; set; }

    public long? ClientClassificationId { get; set; }

    public long? AddressId { get; set; }

    public int EstimateExpirationPeriod { get; set; }

    public string EstimateWording { get; set; }

    public DateTime CreatedDate { get; set; }

    public long CreatedByUserId { get; set; }

    public DateTime ModifiedDate { get; set; }

    public long ModifiedByUserId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsStub { get; set; }
}
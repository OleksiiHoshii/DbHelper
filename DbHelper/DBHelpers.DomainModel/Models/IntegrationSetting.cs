public class IntegrationSetting
{
    public long Id { get; set; }

    public long PracticeId { get; set; }

    public bool VfcEnabled { get; set; }

    public bool? VfcWasEnabledPreviously { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public long CreatedByUserId { get; set; }

    public long ModifiedByUserId { get; set; }

    public bool IsStub { get; set; }

    public Guid? IntegrationSettingKey { get; set; }
}
public interface ICRMUpdater
{
    void UpdateCRMRecord(Guid recordId, string attributeName, string attributeValue);
}

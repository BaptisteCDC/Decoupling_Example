public class CRMElement{
    public readonly Guid RecordId ;
    public readonly string AttributeName;
    public readonly string AttributeValue;

    public CRMElement(Guid recordId, string attributeName, string attributeValue)
    {
        RecordId  = recordId;
        AttributeName = attributeName;
        AttributeValue = attributeValue;
    }
}
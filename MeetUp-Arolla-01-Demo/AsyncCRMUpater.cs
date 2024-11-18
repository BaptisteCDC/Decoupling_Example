using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;

namespace MeetUp_Arolla_01_Demo;
public class AsyncCRMUpdater
{

    // Establish a connection to CRM
    private CrmServiceClient ServiceClient;
    public async Task UpdateCRMRecord(Guid recordId, string attributeName, string attributeValue)
    {
        try
        {
            // Create an entity object with the updated attribute
            Entity entity = new Entity("entity_name"); // Replace "entity_name" with the logical name of your entity
            entity.Id = recordId;
            entity[attributeName] = attributeValue; // Replace "attribute_name" with the logical name of the attribute
            // Update the record synchronously
            ServiceClient.Update(entity);
            Console.WriteLine($"Record with ID {recordId} updated successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error updating record: {ex.Message}");
        }
    }
    public AsyncCRMUpdater(string connectionString)
    {
        ServiceClient = new CrmServiceClient(connectionString);
    }


}











using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;

namespace MeetUp_Arolla_01_Demo;
public class CRMUpdater
{
    public static void UpdateCRMRecord(string connectionString, Guid recordId, string attributeValue,string entityName,string attributeName)
    {
        try
        {

            /// Main treatment 
           

            /// User Inscription


            /// End Main Treatment
            // Establish a connection to CRM
            CrmServiceClient serviceClient = new CrmServiceClient(connectionString);

            // Create an entity object with the updated attribute
            Entity entity = new Entity(entityName); // Replace "entity_name" with the logical name of your entity
            entity.Id = recordId;
            entity[attributeName] = attributeValue; // Replace "attribute_name" with the logical name of the attribute


            // Update the record synchronously
            serviceClient.Update(entity);

            Console.WriteLine($"Record with ID {recordId} updated successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error updating record: {ex.Message}");
        }


    }

    // Example usage (replace placeholders with actual values)
    public static void Main(string[] args)
    {
        string connectionString = "your_connection_string"; // Your CRM connection string
        Guid recordId = new Guid("record_guid");          // GUID of the record you want to update
        string attributeName = "attribute_logical_name"; // Logical name of the attribute to update
        string attributeValue = "new_attribute_value";    // New value for the attribute

        UpdateCRMRecord(connectionString, recordId, attributeName, attributeValue);
    }



}


using Microsoft.Azure.ServiceBus;
using System.Configuration;
using System.Text;
using System.Text.Json;
namespace MeetUp_Arolla_01_Demo;
public class CRMUpdaterSB : ICRMUpdater
{
public QueueClient CRMQueueClient;

    private void PushOnCRMQueue(CRMElement CRMElement)
    {
        try
        {
            var jsonCRMElement = JsonSerializer.Serialize(CRMElement);
            var message = new Message(Encoding.UTF8.GetBytes(jsonCRMElement));
            CRMQueueClient.SendAsync(message).Wait();
            Console.WriteLine("Entity sent to Service Bus successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error sending entity to Service Bus: {ex.Message}");

        }
    }
    public void UpdateCRMRecord(Guid recordId, string attributeName, string attributeValue)
    {
        try
        {
            CRMElement crmElement = new CRMElement(recordId, attributeName, attributeValue);
            PushOnCRMQueue(crmElement);
            Console.WriteLine($"Record with ID {recordId} updated successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error updating record: {ex.Message}");
        }
    }
    public CRMUpdaterSB()
    {
        ServiceBusConnectionStringBuilder serviceBusConnectionStringBuilder = new ServiceBusConnectionStringBuilder(ConfigurationManager.ConnectionStrings["CRMQueue"].ConnectionString);
        CRMQueueClient = new QueueClient(serviceBusConnectionStringBuilder);;
    }


}










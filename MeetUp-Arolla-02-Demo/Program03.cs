    
namespace MeetUp_Arolla_03_Demo;
    public class CRMUpdater3
{
    public static void Main(string[] args)
    {
        /// Main treatment 
    
        /// User Inscription

        /// End Main Treatment
        string connectionString = "your_connection_string"; // Your CRM connection string
        AsyncCRMUpdater crmUpdater = new AsyncCRMUpdater(connectionString);

        var CRMArray = [{Guid("record_guid"), "attribute_logical_name", "new_attribute_value"},
         {Guid("record_guid2"), "attribute_logical_name2", "new_attribute_value2"},
         {Guid("record_guid3"), "attribute_logical_name3", "new_attribute_value3"}].ToList();

        CRMArray.ForEach(record => crmUpdater.UpdateCRMRecord(record[0], record[1], record[2]));
    }
}
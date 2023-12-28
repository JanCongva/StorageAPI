using Microsoft.AspNetCore.Mvc;

namespace StorageAPI.Entities
{
	public class InMemoryStorage : IStorageType
	{
        public ActionResult<string> PostDocument([FromBody] Document document)
		{
			// Implementation for InMemoryStorage
			return "";
		}

        public string GetDocument(string id)
        {
            // Implementation for Database
            return "";
        }
    }
}


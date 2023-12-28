using System;
using Microsoft.AspNetCore.Mvc;

namespace StorageAPI.Entities
{
	public class DatabaseStorage : IStorageType
	{
        public ActionResult<string> PostDocument([FromBody] Document document)
		{
            // Implementation for Database
            return "";
        }

        public string GetDocument(string id)
        {
            // Implementation for Database
            return "";
        }
    }
}


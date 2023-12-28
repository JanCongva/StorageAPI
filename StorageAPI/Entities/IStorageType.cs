using System;
using Microsoft.AspNetCore.Mvc;

namespace StorageAPI.Entities
{
	public interface IStorageType
	{
        public ActionResult<string> PostDocument([FromBody] Document document);

        public string GetDocument(string id);
    }
}


using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace StorageAPI.Entities
{
	public class ServerStorage : IStorageType
	{
        public ActionResult<string> PostDocument([FromBody] Document document)
        {
            var jsonContent = JsonConvert.SerializeObject(document.Data);

            var xmlnode = JsonConvert.DeserializeXmlNode(jsonContent, "data");
            var xmldecl = xmlnode.CreateXmlDeclaration("1.0", "UTF-8", null);

            xmlnode.InsertBefore(xmldecl, xmlnode.FirstChild);

            var filename = document.Id + ".xml";
            var filepath = Path.Combine(Directory.GetCurrentDirectory(), "Upload", "Files");

            if (!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
            }

            filepath = Path.Combine(filepath, filename);

            xmlnode.Save(filepath);

            return filepath;
        }

        public string GetDocument(string id)
        {
            return Path.Combine(Directory.GetCurrentDirectory(), "Upload", "Files", id);
        }
    }
}


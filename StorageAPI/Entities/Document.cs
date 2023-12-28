using System;
using Newtonsoft.Json.Linq;

namespace StorageAPI.Entities
{
    public class Document
    {
        public string Id { get; set; }
        public List<string> Tags { get; set; }
        public JObject Data { get; set; }
    }
}


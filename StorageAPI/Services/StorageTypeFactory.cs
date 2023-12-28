using System;
using Microsoft.Extensions.Options;
using StorageAPI.Entities;

namespace StorageAPI.Services
{
    public class StorageTypeFactory : IStorageTypeFactory
    {
        private readonly ConfigSettings _confSettings;

        public StorageTypeFactory(IOptions<ConfigSettings> confSettings)
        {
            _confSettings = confSettings.Value;
        }

        public IStorageType CreateStorageType()
        {
            switch (_confSettings.StorageType)
            {
                case "server": return new ServerStorage();
                case "data ": return new DatabaseStorage();
                case "inmemory ": return new InMemoryStorage();
                default: return new ServerStorage();
            }
        }
    }
}


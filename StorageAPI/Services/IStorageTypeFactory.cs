using StorageAPI.Entities;

namespace StorageAPI.Services
{
    public interface IStorageTypeFactory
    {
        IStorageType CreateStorageType();
    }
}


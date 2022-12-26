using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Services
{
    public interface ICacheService
    {
        T GetItem<T>(string key);
        void SetItem<T>(string key, T item);
    }
}

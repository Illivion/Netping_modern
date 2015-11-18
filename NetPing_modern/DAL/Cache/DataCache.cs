using System;
using System.Collections.Generic;
using System.Web;
using NetPing.Tools;

namespace NetPing.DAL
{
    internal class DataCache
    {
        private readonly IDataStorage _storage = new InFileDataStorage();

        public static DataCache Instance { get; set; }

        public IEnumerable<T> GetAndCache<T>(String name)
        {
            var cachedCollection = HttpRuntime.Cache.Get(name);

            if (cachedCollection != null)
            {
                // ���������� ��������� � ���� ���������
                return (IEnumerable<T>) cachedCollection;
            }

            try
            {
                var storedCollection = _storage.Get<T>(name);

                // �������� ��������� � ��������� ���������
                HttpRuntime.Cache.Insert(name, storedCollection, new TimerCacheDependency());

                // ���������� ��������� � ��������� ���������
                return storedCollection;
            }
            catch (Exception ex)
            {
                throw new DataNotFoundException("Unable to find data collection in storage", ex);
            }
        }
    }
}
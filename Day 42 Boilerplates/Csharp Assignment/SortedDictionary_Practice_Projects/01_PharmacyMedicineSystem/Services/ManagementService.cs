using System.Collections.Generic;
using Domain;
using Exceptions;

namespace Services
{
    public class ManagementService
    {
        private readonly SortedDictionary<int, List<BaseEntity>> _data = [];

        public void AddEntity(int key, BaseEntity entity)
        {
            // TODO: Validate entity
            if (entity == null) throw new CustomBaseException("Entity cant be null");
            // TODO: Handle duplicate entries
            if(_data.ContainsKey(key)) throw new CustomBaseException("Key already Exists");
            // TODO: Add entity to SortedDictionary
            _data[key] = [entity];
        }

        public static void UpdateEntity(int key)
        {
            // TODO: Update entity logic
        }

        public void RemoveEntity(int key)
        {
            // TODO: Remove entity logic
            _data.Remove(key);
        }

        public IEnumerable<BaseEntity> GetAll()
        {
            // TODO: Return sorted entities
            return _data.Values.SelectMany(x => x);
        }
    }
}

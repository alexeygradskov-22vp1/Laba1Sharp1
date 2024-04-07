using Laba1Sharp1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2Sharp
{
    public delegate void CollectionChangedHandler(string action, string key);
    class Repository
    {
        private Dictionary<string, Library> _collection;

        public event CollectionChangedHandler CollectionChanged;
        public Repository()
        {
            _collection = new Dictionary<string, Library>();
        }

        public void add(string key, Library value)
        {
            _collection.Add(key, value);
            OnCollectionChanged("Added", key);
        }
        public Library getEl(string key)
        {
            return _collection[key];
        }
        public void remove(string key)
        {
            if (_collection.ContainsKey(key))
            {
                _collection.Remove(key);
                OnCollectionChanged("Removed", key);
            }
          
        }

        public Dictionary<string, Library> getAll()
        {
            return _collection;
        }

        public void changeEl(string key, Library changed)
        {
            _collection[key] = changed;
        }

        protected virtual void OnCollectionChanged(string action, string key)
        {
            CollectionChanged?.Invoke(action, key);
        }
    }
}


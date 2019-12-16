using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class FamilyTree<T> : ICollection<T>
    {
        T[] humans;

        public FamilyTree()
        {
            humans = new T[0];
        }

        public T this[int index]
        {
            get { return humans[index]; }

        }
        #region Методы для работый с коллекциями.

        //Метод, который добавляет родственника в коллекцию.
        public void Add(T item)
        {
            T[] newhumans = new T[humans.Length + 1];
            humans.CopyTo(newhumans, 0);
            newhumans[newhumans.Length - 1] = item;
            humans = newhumans;
        }

        //Метод, который удаляет родственника из коллекции.
        public bool Remove(T item)
        {
            if (Contains(item) == true)
            {
                T[] newhumans = new T[humans.Length];
                int j = 0, i = 0;

                foreach (T element in humans)
                {
                    if (element.Equals(item))
                    {
                        T[] newhumansInner = new T[newhumans.Length - 1];
                        foreach (var itemInner in newhumans)
                        {
                            if (itemInner != null)
                            {
                                newhumansInner[i] = itemInner;
                                i++;
                            }
                            else { continue; }
                        }
                        newhumans = newhumansInner;
                    }
                    else
                    {
                        newhumans[j] = element;
                        j++;
                    }
                }
                humans = newhumans;
                return true;
            }
            else
                throw new Exception();
        }

        //Метод, который возвращает количество родственников.
        public int Count
        {
            get { return humans.Length; }
        }

        public bool Contains(T item)
        {
            foreach (var element in humans)
            {
                if (element.Equals(item))
                    return true;
            }
            return false;
        }

        public void Clear()
        {
            humans = new T[0];
        }

        public bool IsReadOnly
        {
            get { return false; }
        }
        
        public void CopyTo(T[] array, int arrayIndex)
        {
            humans.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)humans).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return humans as IEnumerator;
        }
        #endregion
    }
}

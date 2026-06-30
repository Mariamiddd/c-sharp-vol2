using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization.Metadata;

namespace davaleba15
{
    public static class Algorithms
    {
        //where 
        public static IEnumerable<T> Filter<T>(
            this IEnumerable<T> filteredData, Func<T, bool> predicate)
        {
            foreach (T item in filteredData)
            {
                if (predicate(item))
                {
                    yield return item;

                }
            }
        }

        //////////////////////////////////////////////////////////////

        //orderby 
        public static IEnumerable<T> OrderedData<T, TValue>(this IEnumerable<T> data, Func<T, TValue> keySelector)
            where TValue : IComparable<TValue>
        {
            List<T> list = new List<T>(data);

            // usin bubble sort
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - 1 - i; j++)
                {
                    TValue value1 = keySelector(list[j]);
                    TValue value2 = keySelector(list[j + 1]);

                    if (value1.CompareTo(value2) > 0)
                    {
                        //  swaping places
                        T temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }

            foreach (T item in list)
            {
                yield return item;
            }
        }

        //3 first
        public static T FirstElement<T>(this IEnumerable<T> data)
        {
            foreach (T item in data)
            {
                return item;
            }
            return default;

        }


        //4firstor defaulr
        public static T FirstOrDefault<T>(this IEnumerable<T> data)
        {
            foreach (T item in data)
            {
                return item;
            }
            return default(T);
        }

        //5 single element or exception
        public static T CustomSingle<T>(this IEnumerable<T> data, Func<T, bool> predicate)
        {
            T result = default(T);
            bool found = false;

            foreach (T item in data)
            {
                if (predicate(item))
                {
                    if (found) throw new InvalidOperationException("found more than 1 element");
                    result = item;
                    found = true;
                }
            }

            if (!found) 
                throw new InvalidOperationException("element wasnt found");
            return result;
        }

        //6. single or default

        public static T CustomSingleOrDefault<T>(this IEnumerable<T> data, Func<T, bool> predicate)
        {
            T result = default(T);
            bool found = false;

            foreach (T item in data)
            {
                if (predicate(item))
                {
                    if (found) throw new InvalidOperationException("foud more than 1 element");
                    result = item;
                    found = true;
                }
            }

            return result; // if not found resultt will be defalt anu 0
        }

        //7. any
        public static bool CustomAny<T>(this IEnumerable<T> data, Func<T, bool> predicate)
        {
            foreach (T item in data)
            {
                if (predicate(item))
                    return true;
            }
            return false;
        }

        //8. all
        public static bool CustomAll<T>(this IEnumerable<T> data, Func<T, bool> predicate)
        {
            foreach(T item in data)
            {
                if (!predicate(item)) 
                    return false;  //if one isnt true it will rerun false
            }
            return true; //else returns true
        }


        //9. customcount
        public static int CustomCount<T>(this IEnumerable<T> data, Func<T, bool> predicate = null)
        {
            int count = 0;
            foreach(T item in data)
            {
                if(predicate == null || predicate(item))
                {
                    count++;
                }

            }
            return count;
        }

        //10 distinct

        public static IEnumerable<T> CustomDistinct<T>(this IEnumerable<T> data)
        {
            List<T> allElements = new List<T>();

            foreach (T item in data)
            {
                if (!allElements.Contains(item))
                {
                    allElements.Add(item); 
                    yield return item;      
                }
            }
        }



    }
}

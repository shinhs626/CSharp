using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace GenericClass
{
    public class Person
    {
        public string Name { get; set; }
    }

    public class CollectionInitializers : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            List<Person> people = new List<Person>()
            {
                new Person {Name = "홍길동"},
                new Person {Name = "백두산"},
                new Person {Name = "장길산"}
            };

            foreach(var i in people)
            {
                Debug.Log(i.Name);
            }
        }
    }

}

using System.Collections.Generic;
using System.Collections;
using UnityEngine;

namespace GenericClass
{
    public class Student
    {
        public string Name { get; set; }
        public int Number { get; set; }
    }

    //제네릭 클래스(List<T>)
    //형식 매개변수 T에 지정한 형식으로 클래스와 멤버의 성질이 결정되는 클래스
    public class GenericCollection : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //학생 전용 리스트
            List<Student> students = new List<Student>()
            {
                new Student {Name="홍길동",Number=1},
                new Student {Name="백두산",Number=2},
                new Student {Name="장길산",Number=3}
            };
            Student student = new Student() { Name = "김단비", Number = 4 };
            students.Add(student);
            
            foreach(var i in students)
            {
                Debug.Log($"이름:{i.Name}번호:{i.Number}");
            }
        }
    }

}

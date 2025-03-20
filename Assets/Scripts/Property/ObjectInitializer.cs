using UnityEngine;

namespace Property
{
    public class ObjectInitializer : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Student 인스턴스 생성
            Student s1 = new Student();
            s1.Name = "홍길동";
            s1.Age = 20;
            Debug.Log($"{s1.Name} {s1.Age} {s1.Number}");

            //ObjectInitializer 를 사용하여 개체 초기화
            Student s2 = new Student() { Name = "백두산", Age = 22, Number = 2 };
            Debug.Log($"{s2.Name} {s2.Age} {s2.Number}");

            Student s3 = new Student() { Name = "도깨비", Age = 24, Number = 3 };
            s3.SetAddress("부산");
            Debug.Log($"{s3.Name} {s3.Age} {s3.Number} {s3.GetAddress()}");

        }
    }
}


using UnityEngine;

namespace InheritanceK
{
    public class AbstractClassNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1] squre, circle 클래스의 인스턴스(객체) 생성
            Squre squre = new Squre(10);
            Debug.Log(squre.GetArea());

            Circle circle = new Circle(10);
            Debug.Log(circle.GetArea());
        }
    }
}


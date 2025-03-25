using UnityEngine;

namespace GenericClass
{
    public class GenericMethod : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Hello(제네릭) 클래스 인스턴스 생성
            Hello<int> hello = new Hello<int>();
            hello.Say(1234);
            Debug.Log(hello.GetMessage());
        }
    }

}

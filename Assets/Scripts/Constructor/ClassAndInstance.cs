using UnityEngine;

namespace Constructor
{
    public class ClassAndInstance : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Dog 클래스의 인스턴스 생성
            Dog dog = new Dog("HAPPY");
            Debug.Log(dog.Cry());

            //Dog 클래스의 다른 인스턴스 생성
            Dog worry = new Dog("SAD");
            Debug.Log(dog.Cry());
        }
    }
}


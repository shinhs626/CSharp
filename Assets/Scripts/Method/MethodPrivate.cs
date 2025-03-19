using UnityEngine;

namespace Method
{
    public class MethodPrivate : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Dog 클래스의 인스턴스 생성
            Dog dog = new Dog();

            dog.Eat();              //[1] public 메서드 호출 가능
            dog.weight = 30;        //[2] public 필드 접근 가능
            //dog.Digest();         //[3] private 메서드 호출 불가능
        }
    }

}

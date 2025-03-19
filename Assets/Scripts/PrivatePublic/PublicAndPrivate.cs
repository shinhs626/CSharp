using UnityEngine;

namespace PrivatePublic
{
    public class PublicAndPrivate : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1]Car 클래스의 객체(인스턴스) 생성
            Car myCar = new Car();

            //[2]Car 클래스의 객체를 통해 public한 필드에 접근해서 사용
            myCar.name = "홍길동";
            myCar.Hi();
            Debug.Log(myCar.name);

            //[3]Car 클래스의 객체를 통해 private한 필드에 접근해서 사용(x)
            //myCar.age = 21; //액세스 한정자 문제
            //myCar.Bye();

            //[4]private한 필드(age)를 외부에 공개하고자 할 때 public한 메서드를 이용한다
            myCar.SetAge(21);
            Debug.Log(myCar.GetAge());
        }
    }
}


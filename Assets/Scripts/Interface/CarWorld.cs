using UnityEngine;

namespace InterfaceTest
{
    public class CarWorld : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1] car 클래스 인스턴스 생성
            Car campingCar = new Car("캠핑 카");
            campingCar.Run();

            //[2] 속성
            Car sportCar = new Car();
            sportCar.Name = "스포츠카";
            sportCar.Run();

            //[3]
            Car cars = new Car(2);
            cars[0] = "1번 자동차";
            cars[1] = "2번 자동차";

            foreach(var i in cars)
            {
                Debug.Log(i);
            }
        }
    }

}

/*
객체지향 프로그래밍
- 추상화
- 캡슐화
- 상속
*/
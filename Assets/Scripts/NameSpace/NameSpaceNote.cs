using UnityEngine;

//Korea.Suwon에 있는 클래스를 가져다 사용하기
using Korea.Suwon;
//별칭을 사용해서 사용하기, Korea.Suwon을 Su 네임스페이스로 바꾸어서 사용
using Su = Korea.Suwon;

public class NameSpaceNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 네임스페이스 이름 전체를 지정해서 사용하기
        Korea.Seoul.Car se = new Korea.Seoul.Car();
        se.Run();   //자동차가 달립니다

        Korea.Suwon.Car su = new Korea.Suwon.Car();
        se.Run();   //자동차가 달립니다

        //[2] 네임스페이스 선언부에 using을 선언하여 사용하기
        Car seoul = new Car();
        seoul.Run();

        //[3]
        Su.Car suwon = new Su.Car();
        suwon.Run();

        //Truck 호출하기
        Korea.Seoul.Truck seoulTruck = new Korea.Seoul.Truck();
        se.Run();   //트럭이 달립니다.
    }
}

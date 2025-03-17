// 네임 스페이스 선언부
using UnityEngine;  //UnityEngine 네임스페이스에 있는 클래스를 가져다 사용한다
using Foo;
using Bar;

//NameSpace(네임스페이스)
//1. 클래스(사용자 정의 형식) 등 등을 서로 관련 있는 (비슷한 기능) 것들끼리 묶어서 관리
//2. 같은 이름의 충돌을 방지

public class NameSpaceDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]Foo 네임스페이스의 있는 Car클래스 호출
        //Car의 객체 만들기
        Foo.Car fooCar = new Foo.Car();
        fooCar.Go();

        //[2]Bar 네임스페이스의 있는 Car클래스 호출
        //Car의 객체 만들기Foo.Car fooCar = new Foo.Car();
        Bar.Car BarCar = new Bar.Car();
        BarCar.Go();
    }
}
/*
// NameSpace 선언
// nameSpace 네임스페이스 이름 
{

}
*/
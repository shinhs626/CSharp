using UnityEngine;

namespace Delegate
{
    public class DelegateNote : MonoBehaviour
    {
        //집에가기 : 직 -> 우 -> 직 - 좌

        //대리자 선언 - 반환값도 없고, 매개변수 없다
        delegate void GoHome();
        GoHome go;

        //Action 형식을 통해 대리자 객체 생성
        //Action , Func
        System.Action driver;

        //대리자 선언
        delegate void Say();
        //Delegate 변수 선언
        Say say3;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            CarDriver.GoForward();
            CarDriver.GoRight();
            CarDriver.GoForward();
            CarDriver.GoLeft();

            //대리자 변수
            go = new GoHome(CarDriver.GoForward);
            go += new GoHome(CarDriver.GoRight);        //메서드 등록 가능
            go += new GoHome(CarDriver.GoForward);      //메서드 등록 가능
            go += new GoHome(CarDriver.GoLeft);         //메서드 등록 가능
            go();

            //대리자 변수 선언 및 메서드 등록
            Say say = new Say(Hello);
            say += new Say(Hi);
            say.Invoke();

            //대리자 변수 선언 및 메서드 등록
            Insa insa = new Insa();
            Say say2 = insa.Bye;
            say2 += insa.Bye;
            say2 += Hi;
            say2.Invoke();

            //메서드 등록 및 호출 : say3 = null;
            /*if(say3 != null)
            {
                say3.Invoke();
            }*/
            say3?.Invoke();

            driver = CarDriver.GoForward;
            driver += CarDriver.GoRight;
            driver += () => Debug.Log("후진");
            driver += delegate () { Debug.Log("주차"); };
            driver?.Invoke();
        }
        void Hello() => Debug.Log("Hello");
        void Hi() => Debug.Log("Hi");
    }

}

using UnityEngine;

//UnaryOperator(단항연산자): +,-,++,-- 등 연산을 진행할 때 한 개의 피연산자만 사용하는 연산자
public class UnaryOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //int형 변수 value를 선언하고 0으로 초기화
        int value = 0;

        //[1]
        value = 8;  //value에 8을 할당 => 8
        value = +value;
        Debug.Log(value); // == 8

        //[2]
        value = -8; //value에 -8을 할당 => -8
        value = +value;
        Debug.Log(value);// == -8

        //[3]
        value = 8; //value에 8을 할당 => 8
        value = -value;
        Debug.Log(value);// == -8

        //[4]
        value = -8; //value에 -8을 할당 => -8
        value = -value;
        Debug.Log(value);// == 8

    }
}

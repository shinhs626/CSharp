using UnityEngine;

//콤마를 사용하여 동일 데이터 형식을 갖는 변수 여러개 만들기
public class VariableComma : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 변수 number1,2,3 선언

        //int number1;
        //int number2;
        //int number3;

        int number1, number2, number3;

        //[2] 변수에 값을 대입(할당)
        number1 = 1;
        number2 = 2;
        number3 = 3;

        //[3] 변수 출력(참조)
        Debug.Log(number1+","+number2 + "," + number3);
    }
}

using UnityEngine;

public class IfElseIfElse : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //number1, number2 값을 입력받아서
        //[1] number1이 크면 number1이 크다라고 출력
        //[2] number2가 크면 number2가 크다라고 출력
        //[3] 둘 다 같으면 둘 다 같다라고 출력

        int number1 = 10;
        int number2 = 10;

        if (number1 > number2)
        {
            Debug.Log("number1이 크다");
        }
        else if (number1 < number2)
        {
            Debug.Log("number2가 크다");
        }
        else
        {
            Debug.Log("둘 다 같다");
        }
    }
}

/*
Else If 문

[1]조건식 1이 참이면
선언문 -> 실행문1 -> 실행문4

[2]조건식 1이 거짓이고 조건식 2가 참이면
선언문 -> 실행문2 -> 실행문4

[3]조건식 1, 2가 거짓이면
선언문 -> 실행문3 -> 실행문4

[4]조건식1이 참이고, 2가 참이면
선언문 -> 실행문1 -> 실행문4

*/
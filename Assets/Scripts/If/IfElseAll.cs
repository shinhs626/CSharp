using UnityEngine;

public class IfElseAll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //하나의 정수를 입력 받아서 짝수이면 "짝수입니다", 홀수이면 "홀수입니다"를 출력
        //짝수도 홀수도 아닌 경우 "짝수도 홀수도 아닙니다."를 출력

        int number = 42;

        if(number % 2 == 0)//짝수 판별식
        {
            Debug.Log("짝수입니다.");
        }
        else if(number % 2 != 0)//홀수 판별식
        {
            Debug.Log("홀수입니다.");
        }

        //3의 배수 판별식
        if (number % 3 == 0)
        {
            Debug.Log($"{number}는 3의 배수입니다.");
        }
        else if(number % 5 == 0)
        {
            Debug.Log($"{number}는 5의 배수입니다.");
        }
        else if(number % 7 == 0)
        {
            Debug.Log($"{number}는 7의 배수입니다.");

        }
        else
        {
            Debug.Log($"{number}는 3, 5, 7의 배수가 아닙니다.");
        }
    }
}

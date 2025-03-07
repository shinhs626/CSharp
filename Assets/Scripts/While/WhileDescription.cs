using UnityEngine;

public class WhileDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        for(int i = 0; i < 3; i++)
        {
            Debug.Log("안녕하세요");
        }
        */
        /*
        for(int i = 1; i < 4; i++)
        {
            Debug.Log("안녕하세요");
        }
        */
        /*
        for(int i = 0; i <= 3; i++)
        {
            Debug.Log("안녕하세요");
        }
        */
        int i = 0;

        while (i < 3)
        {
            Debug.Log($"안녕하세요 i는 {i+1}입니다");
            i++;
        }

        //조건식 판별(i:0) 참 -> 반복문 실핼 -> 증감식 -> 조건식 판별(i:1) 참 -> 반복문 실행 -> 증감식
        //-> 조건식 판별(i:2) 참 -> 반복문 실행 -> 증감식 -> 조건식 판별(i:3) 거짓 -> while문 종료
    }
}
/*
while문 - 반복문
조건식이 true이면 반복문을 실행 false이면 while문을 종료

while(조건식)
{
    //반복 실행문

    //조건식의 들어가는 증감식
}

조건식 판별(참) -> 반복문 실행 -> 조건식 판별(참) -> 반복문 실행 -> 조건식 판별(거짓) -> while문 종료

*/
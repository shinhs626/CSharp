using UnityEngine;

public class DoWhile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 0;

        do
        {
            Debug.Log("안녕하세요");
            i++;
        } while (i < 3);
        
    }
}

/*
DoWhile 문 - 반복문
먼저 반복 실행문을 1번 실행한다
조건식이 true이면 반복문을 실행한다
조건식이 false이면 while문을 종료한다

do 
{
    //반복 실행문
}   while(조건식)

*/
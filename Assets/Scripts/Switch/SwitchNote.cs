using UnityEngine;

public class SwitchNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 선언문
        int x = 3;

        //[2] switch문
        switch (x)// x의 값에 따라 case문 실행
        {
            case 1:
                Debug.Log("1입니다.");//[2] 실행문1
                break;
            case 2:
                Debug.Log("2입니다.");//[3] 실행문2
                break;
            case 3:
                Debug.Log("3입니다.");//[4] 실행문3
                break;
            default:
                Debug.Log("1, 2, 3이 아닙니다.");
                break;
        }
        Debug.Log("프로그램 종료");//[5] 실행문4

        //int x = 1;
        //[1] -> [2] -> [5]
        //int x = 2;
        //[1] -> [3] -> [5]
        //int x = 3;
        //[1] -> [4] -> [5]
        //int x = 4;
        //[1] -> [5]
    }
}
/*
switch문 : 조건문 - 선택문

switch(조건) : Data 값 판별
{
    case 1 : 조건이 1일 때 실행
    {
        실행문1
        break;
    }
    case 2 : 조건이 2일 때 실행
    {
        실행문2
        break;
    }
    case 3 : 조건이 3일 때 실행
    {
        실행문3
        break;
    }
    default : 조건이 1, 2, 3이 아닐 때 실행
    {
        실행문4
        break;
    }
}


if(조건식) : 조건식이 참일 때 실행
{
    실행문1
}
else : 조건식이 거짓일 때 실행 
{
    실행문2
}
*/
using UnityEngine;

public class ElseNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (1 != 1)
        {
            //Debug.Log("1과 1은 같지 않습니다");
        }
        else
        {
            Debug.Log("1과 1은 같습니다");
        }
    }
}

/*
else 문
만약 조건식이 참이라면 실행문1 실행 거짓이라면 실행문2 실행


if(조건식)
{
    //조건식이 참일 때 실행문1(명령문)을 실행
}
else
{
    //조건식이 거짓일 때 실행문2(명령문)을 실행
}

//실행문3

1.조건식이 참이면 실행문1을 실행하고 실행문3을 실행
2.조건식이 거짓이면 실행문2을 실행하고 실행문3을 실행
*/
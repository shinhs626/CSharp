using UnityEngine;

// 실행문: 단문(한줄), 복문(여러줄)
public class SingleMulti : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //만약 조건식이 참이면 { }안에 있는 실행문을 실행한다.
        /*
        if(조건식)
        {
            //실행문1
            //실행문2
            //...
        }
        */

        //단문은 {} 실행문이 1개
        if(1 == 1)
        {
            Debug.Log("단문1");
        }

        if(1 == 1) //{} 생략이 되면 바로 아래있는 1줄만 실행
            Debug.Log("단문2");

        if (1 == 1) Debug.Log("단문3"); //단문은 ; 생략 가능

        //복문(실행문이 2개 이상일때)
        if (1 == 1)
        {
            Debug.Log("복문1");
            Debug.Log("복문2");
        }
    }
}

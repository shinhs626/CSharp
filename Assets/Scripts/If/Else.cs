using UnityEngine;

public class Else : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 61;//[1]

        if (score >= 60)//조건식이 참일 때 실행문1(명령문)을 실행
        {
            Debug.Log("합격입니다.");//[2]
        }
        else//조건식이 거짓일 때 실행문2(명령문)을 실행
        {
            Debug.Log("불합격입니다.");//[3]
        }
        Debug.Log("시험이 끝났습니다.");//[4]

    }

    //score = 59; : [1] -> [3] -> [4]
    //score = 60; : [1] -> [2] -> [4]

}

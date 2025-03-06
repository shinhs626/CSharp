using UnityEngine;

public class IfElsePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 85;
        string medal = "";

        if (score >= 90)
        {
            medal = "금메달";
        }
        else
        {
            if(score >= 80)
            {
                medal = "은메달";
            }
            else
            {
                if(score >= 70)
                {
                    medal = "동메달";
                }
                else
                {
                    {
                        Debug.Log("탈락하셨습니다");
                    }
                }
            }
        }
        Debug.Log($"{medal}을 수상하셨습니다");
    }
}
/*
[Q]
score 가 90이상이면 금메달 출력, 80이상이면 은메달 출력, 70이상이면 동메달 출력, 그외 나머지는 탈락 출력

*/
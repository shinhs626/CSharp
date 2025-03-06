using UnityEngine;

public class ElseIf : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //score가 90점 이상이면 A학점, 80점 이상이면 B학점, 70점 이상이면 C학점, 60점 이상이면 D학점, 그 외에는 F학점을 출력

        int score = 59;
        char grade = 'A';

        if (score >= 90)//[1] 90점 이상이면
        {
            grade = 'A';
        }
        else if (score >= 80)//[2] 80점 이상이면
        {
            grade = 'B';
        }
        else if (score >= 70)//[3] 70점 이상이면
        {
            grade = 'C';
        }
        else if (score >= 60)//[4] 60점 이상이면
        {
            grade = 'D';
        }
        else
        {
            grade = 'F';
        }
       
        Debug.Log($"학점은 {grade}학점 입니다");
    }
}

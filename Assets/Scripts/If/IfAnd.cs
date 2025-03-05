using UnityEngine;

//&&, ||
public class IfAnd : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number = 1234;

        //조건식 2개 : number가 1234와 같냐?, number가 1000보다 크거나 같냐?
        //2개의 조건식이 모두 만족하면(&&) 맞습니다 출력
        if (number == 1234 && number >= 1000)
        {
            Debug.Log("맞습니다");
        }

        //조건식 2개 : number가 1234와 같냐?, number가 1000보다 작거나 같냐?
        //2가지 조건중 하나라도 만족하면(||) 실행문(명령문)을 실행
        if(number == 1234 || number <= 1000)
        {
            Debug.Log("number는 1234이거나 1000보다 작거나 같습니다");
        }
    }
}

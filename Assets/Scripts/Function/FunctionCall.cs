using UnityEngine;

public class FunctionCall : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] 함수 호출하기
        for(int i = 0; i < 3; i++)
        {
            Hello();
        }
    }
    //[1]함수 만들기(선언,정의(
    void Hello()
    {
        Debug.Log("안녕하세요");
    }
}

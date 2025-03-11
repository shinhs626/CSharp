using UnityEngine;

public class MethodOverloadDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Hi();
        Hi("안녕하세요");
        Hi("안녕하세요",5);
    }

    //인사하는 함수
    //매개변수가 없는 함수
    void Hi()
    {
        Debug.Log("안녕하세요");
    }
    
    //매개 변수로 입력 받은 (msg)로 인사하는 함수
    void Hi(string msg)
    {
        Debug.Log(msg);
    }

    //매개 변수로 입력 받은 (msg)를 매개 변수로 받은 (count) 횟수 만큼 인사
    void Hi(string msg, int count)
    {
        for(int i = 0; i < count; i++)
        {
            Debug.Log(msg);
        }
    }
}

using UnityEngine;

public class TryCatchDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        try
        {
            int[] arr = new int[2];
            arr[1] = 10;
        }
        catch
        {
            Debug.Log("오류발생");
        }
    }
}

/*
예외 처리(Exception Handling)   :   try-catch-finally 문을 사용
예외(오류, 버그)
-   문법 오류                   코드 오류
-   런타임 오류                  게임을 시작했을때 예)유니티 시작 버튼을 누른 뒤에 실행중에 나오는 버그
-   알고리즘 오류                 프로그래머의 의도대로 실행되지 않는 오류

구문
try
{
    //명령문
}
catch
{
    //try 코드블록 안에 있는 명령문들을 실행중 예외(Exception) 발생시 처리할 내용
}
*/
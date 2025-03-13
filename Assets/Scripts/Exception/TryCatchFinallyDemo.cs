using UnityEngine;

public class TryCatchFinallyDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()    
    {
        int x = 5;
        int y = 5;
        int result = 0;

        try         //예외가 발생할 가능성이 있는 명령문
        {
            //[1]
            result = x / y;
            Debug.Log($"{x} / {y} = {result}");
        }
        catch       //try 절에서 예외가 발생하면 catch절을 실
        {
            //[2]
            Debug.Log("예외가 발생했습니다.");
        }
        finally     //예외가 발생 하든 말든 마지막에 실행
        {
            //[3]
            Debug.Log("프로그램을 종료하겠습니다");
        }
    }
}

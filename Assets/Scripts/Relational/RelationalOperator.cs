using UnityEngine;

//RelationalOperator(관계 연산자, 비교 연산자)
// < (작다), > (크다), <= (작거나 같다), >= (크거나 같다), == (같다), != (같지 않다)
// 관계 연산자는 두 개의 값을 비교하여 결과로 참(true) 또는 거짓(false)을 반환하는 연산자이다.
public class RelationalOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        int y = 5;

        Debug.Log(x < y);//True
        Debug.Log(x > y);//False
        Debug.Log(x <= y);//True
        Debug.Log(x >= y);//False
        Debug.Log(x == y);//False
        Debug.Log(x != y);//True

        Debug.Log("AAA" == "aaa");//False
        Debug.Log("AAA" != "aaa");//True
    }
}

using UnityEngine;

public class VariableDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int num = 7;    //[1] 변수 선언과 동시에 값 대입(초기화)
        Debug.Log(num); //[2] 변수를 출력(참조)한다
    }
}

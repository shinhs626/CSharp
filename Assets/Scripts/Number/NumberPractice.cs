using UnityEngine;

public class NumberPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float fpi = 3.14f;
        double dpi = 3.14;
        decimal depi = 3.14m;

        Debug.Log("float :" + fpi);
        Debug.Log("double :" + dpi);
        Debug.Log("decimal :" + depi);
    }
}

/*
[Q]
실수형 값 float 3.14, double 3.14, decimal 3.14 값 출력하기
*/
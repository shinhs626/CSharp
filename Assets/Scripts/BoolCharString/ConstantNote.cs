using UnityEngine;

public class ConstantNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //변수
        string name = "홍길동";
        name = "신현성";                //변수이기 때문에 수정 가능함

        //상수
        const int AGE = 20;             //20으로 나이를 고정(const 사용)
        //AGE = 21;                     //상수이기 때문에 수정 불가능함

        //변수, 상수 사용
        Debug.Log($"{name} - {AGE}");

    }
}

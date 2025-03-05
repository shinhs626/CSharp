using UnityEngine;

//NotOperator(부정 연산자) : !(Not)참이면 거짓, 거짓이면 참

public class NotLogical : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 참 일때
        Debug.Log(!true); //False

        //[2] 거짓 일때
        Debug.Log(!false); //True

        //[3] 변수에 저장
        bool bin = false;

        Debug.Log(!bin); //True
        Debug.Log(!!bin);//false
        Debug.Log(!(!(!bin)));//True

    }
}

using UnityEngine;

//OrOperator(Or 연산자) : || 둘 중 하나만 참이면 참
//결고ㅏ : true, false
public class OrOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 둘 다 참이면 참
        Debug.Log(true || true); //True
        
        //[2] 둘 중에 하나라도 참이면 참
        Debug.Log(true || false); //True
        Debug.Log(false || true); //True

        //[3] 둘 다 거짓이면 거짓
        Debug.Log(false || false); //False
    }
}

using UnityEngine;

//LogicalOperator(논리 연산자) : &&(And), ||(Or), !(Not)
//AndOperator(And 연산자) : && 둘 다 참일때만 참
//결과 : True, False
public class AndOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 둘 다 참일 때만 참    
        Debug.Log(true && true); //True

        //[2] 둘 중에 하나라도 거짓이면 거짓
        Debug.Log(true && false); //False
        Debug.Log(false && true); //False

        //[3] 둘 다 거짓이면 거짓
        Debug.Log(false && false); //False









    }
}

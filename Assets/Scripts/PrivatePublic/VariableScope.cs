using UnityEngine;

namespace PrivatePublic
{
    public class VariableScope : MonoBehaviour
    {
        string glovalVarialbe = "전역변수";//Field (필드,전역변수,멤버변수)
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1] 지역변수 선언 및 사용
            string localVariable = "지역변수";
            Debug.Log(localVariable);

            //[2] 함수 호출
            TestPrint();
        }
        
        void TestPrint()
        {
            //Debug.Log(LocalVariable); error
            Debug.Log(glovalVarialbe);
        }
    }
}


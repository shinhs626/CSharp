using UnityEngine;

namespace Method
{
    //OptionalParameter(선택적 매개변수) - 사용해도 되고, 생략해도 되는 매개변수
    public class ParameterOptional : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            int number = Add(5);
            Debug.Log(number);
        }

        //선택적 매개변수 : b
        int Add(int a, int b = 1)
        {
            return a + b;
        }
    }
}


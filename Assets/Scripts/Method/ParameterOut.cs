using UnityEngine;

namespace Method
{
    //[3] 반환형 전달 방법               (out int num)
    public class ParameterOut : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            int number;
            GetNum(out number);

            Debug.Log("[2]" + number);
        }

        //정수형 out number를 매개변수로 입력 받아 출력하는 함수
        void GetNum(out int number)
        {
            number = 20;
            Debug.Log("[1]" + number);
        }
    }
}


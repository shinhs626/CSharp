using UnityEngine;

namespace Method
{
    //[2] 참조 전달 방법                (ref int num)
    //참조형으로 전달을 하면 원본 변수에도 영향을 미쳐 변수가 참조형으로 전달한 매개변수 값으로 바뀐다
    public class ParameterRef : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            int number = 10;
            Debug.Log("[1]" + number);

            GetNum(ref number);

            Debug.Log("[3]" + number);
        }

        //정수형 ref number를 매개변수로 입력 받아 출력하는 함수
        void GetNum(ref int number)
        {
            number = 20;
            Debug.Log("[2]" + number);
        }
    }

}

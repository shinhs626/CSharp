using UnityEngine;

//MethodOverload(메서드 오버로드, 함수 다중 정의)
//동일한 이름의 메서드를 매개 변수를 다르게 해서 여러 개 생성하는 것
public class MethodOverloadNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*PrintNumber(1234);
        PrintNumber(1234L);
        PrintNumber(1234F);*/

        PrintNumber<int>(1234);
        PrintNumber<long>(1234L);
        PrintNumber<float>(1234F);
        PrintNumber<double>(1234);
    }

    //제네릭 메서드
    void PrintNumber<T>(T number)
    {
        Debug.Log($"{number}");
    }

    //함수 다중 정의

    //매개 변수로 숫자를 입력 받아 출력하는 함수
    //int 타입의 정수를 매개 변수로 입력 받아 출력
    void PrintNumber(int num)
    {
        Debug.Log($"int32: {num}");
    }

    //long 타입의 정수를 매개 변수로 입력 받아 출력
    void PrintNumber(long num)
    {
        Debug.Log($"int64: {num}");
    }

    //float 타입의 정수를 매개 변수로 입력 받아 출력
    void PrintNumber(float num)
    {
        Debug.Log($"실수형: {num}");
    }

}

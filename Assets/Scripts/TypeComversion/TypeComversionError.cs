using UnityEngine;

//TypeComversionError (형식변환)
public class TypeComversionError : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] long형 변수 err을 선언하고 long형 변수가 가질 수 있는 최대값을 초기화
        long err = long.MaxValue;

        
        Debug.Log($"err의 값: {err}");//err값을 콘솔창에 출력

        //[2] int형 변수 Err을 선언하고 err값을 할당
        int Err = (int)err;
        Debug.Log($"Err의 값: {Err}");
    }
}

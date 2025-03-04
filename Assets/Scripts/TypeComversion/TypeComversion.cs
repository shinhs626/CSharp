using UnityEngine;

public class TypeComversion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //double형 실수형 변수로 d를 선언하고 12.34로 초기화
        double d = 12.34; //
        //int형 정수형 변수로 i를 선언하고 1234로 초기화
        int i = 1234;

        //[1]double > int : 묵시적(암묵적,암시적) 형변환
        d = i;
        Debug.Log($"암묵적 형변환:{d}");

        d = 12.34;
        i = 1234;

        //[2]int < double : 명시적 형변환 필요
        i = (int)d;// ():캐스팅 연산자
        Debug.Log($"명시적1 형변환:{i}");

        //[3]다른 형식간의 변환
        string s = "";//string 변수 s를 선언하고 ""(빈 값)으로 초기화
        s = d.ToString();//ToString() 메서드로 double형 변수 d를 string형으로 변환
        Debug.Log($"명시적2 형변환:{s}");
    }
}

using UnityEngine;

public class StringPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int numberThree = 3;    //int형 변수 numberThree에 3을 초기화
        string result = "홀수";

        Debug.Log($"{numberThree}은(는) {result}입니다.");

        numberThree = 4;
        result = "짝수";
        Debug.Log($"{numberThree}은(는) {result}였습니다.");
    }
}

/*
[Q]
3, 홀수를 변수 선언하고 초기화한다
문자열 보간법을 이용해서 저장된 데이터 출력


*/
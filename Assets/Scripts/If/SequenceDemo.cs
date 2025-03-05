using UnityEngine;

//순차문 : 위에서 아래로 순서대로 명령문을 실행하는 구문 
public class SequenceDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 변수 선언 - 초기화
        int kor = 100;      //국어점수
        int eng = 90;       //영어점수

        int total = 0;      //총점
        double avg = 0.0;   //평균

        //[2] 변수에 값 대입(할당)
        total = kor + eng;  //총점 계산
        avg = total / 2.0;  //평균 계산

        //[3] 변수를 사용하여 결과 출력
        Debug.Log($"총점 : {total}"); //190
        Debug.Log($"평균 : {avg}"); //95
    }
}
/*
<제어문> : 프로그램의 흐름(순서)를 제어하는 구문
- 순차문 : 위에서 아래로 순서대로 명령문을 실행하는 구문 
- 조건문(if - else, switch) : 조건에 따른 서로 다른 명령문을 실행하는 구문
- 반복문 :
*/
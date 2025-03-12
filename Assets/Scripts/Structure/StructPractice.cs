using UnityEngine;

//중첩 구조체: 구조체안에 구조체
//성적을 관리하는 구조체 만들기
//각 과목의 점수를 관리하는 구조체
struct Score
{
    public int kor;     //국어 점수
    public int eng;     //영어 점수
}

//학생 정보를 관리하는 구조체 선언 - 성적 포함
struct Student
{
    public int number;      //학생 번호
    public string name;     //학생 이름
    public Score scores;    //시험 점수 - Score 구조체 : 중첩 구조체
}

public class StructPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 구조체 변수 선언 및 요소수 생성
        Student[] students = new Student[3];

        students[0].number = 1;
        students[0].name = "이순신";
        students[0].scores.kor = 70;
        students[0].scores.eng = 10;

        students[1].number = 2;
        students[1].name = "세종대왕";
        students[1].scores.kor = 100;
        students[1].scores.eng = 100;

        students[2].number = 3;
        students[2].name = "홍길동";
        students[2].scores.kor = 50;
        students[2].scores.eng = 50;

        //[3] 학생 구조체 사용 - 성적표 출력
        for (int i = 0; i < students.Length; i++)
        {
            Debug.Log($"{students[i].number}-{students[i].name}-국어 점수 : {students[i].scores.kor}-영어 점수 : {students[i].scores.eng}");
        }
    }
}

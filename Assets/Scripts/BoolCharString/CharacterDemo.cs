using UnityEngine;

//숫자 이외의 데이터 형식 : bool, char, string
//char(문자형) :문자 데이터 형식
public class CharacterDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] char 형 변수 선언 및 초기화
        char grade = 'A';
        char kor = '한';
        char ea = '국';

        //[2] 사용하기
        Debug.Log("grade :" + grade);
        Debug.Log("우리나라 :" + kor+ea);

    }
}

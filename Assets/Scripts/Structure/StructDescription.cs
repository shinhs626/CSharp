using UnityEngine;

//[1]구조체 정의, 선언 : 두개의 정수를 관리하는 구조체 만들기
/*struct Point
{
    public int x; //public 키워드를 선언하여 외부에서 int x 변수를 사용 가능하도록 설정
    public string y;
}*/

public class StructDescription : MonoBehaviour
{
    struct Point
    {
        public int x; //public 키워드를 선언하여 외부에서 int x 변수를 사용 가능하도록 설정
        public string y;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2]구조체 형식의 변수 선언
        Point point;

        //[3]x,y변수에 값을 저장(대입,할당), 초기화
        point.x = 100;
        point.y = "200";

        //[4]사용
        Debug.Log($"x: {point.x}, y:{point.x}");
    }
}

/*
Variable(변수) : 데이터를 저장하는 그릇
Array(배열) : 하나의 이름으로 같은 형식의 데이터를 여러 개 담는 그릇, 묶음, 변수의 확인
Struct(구조체) : 하나의 이름으로 서로 다른 데이터들, 또는 함수들을 묶어서 관리하는 그릇 (데이터 구조), 변수의 확장
: 사용자 정의 데이터 형식

//구조체 형식
struct (구조체 이름)
{
    //서로 다른 형식의 데이터들
    //함수들
}
*/
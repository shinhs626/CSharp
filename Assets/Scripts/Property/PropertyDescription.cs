using UnityEngine;

namespace Property
{
    public class PropertyDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1] Developer 클래스의 인스턴스 생성
            Developer dev = new Developer();

            //[2] 속성에 값을 설정
            dev.Name = "홍길동";

            //[3] 속성 값 사용
            Debug.Log(dev.Name);
        }
    }
}

/*
Property(속성) : 필드의 값을 읽거나 쓰거나 연산하는 방법을 제공하는 클래스 멤버
: 클래스의 속성을 나타내는 멤버
: 필드는 기본적으로 private(외부에서 접근 제한)
: 속성은 접근 제한된 필드를 외부에서 읽거나 쓰기가 가능하도록 해준다
: 속성 이름은 맨 앞 알파벳 문자는 대문자로 한다

Property(속성) 형식
public [반환타입] 속성이름 {get; set;}

*/
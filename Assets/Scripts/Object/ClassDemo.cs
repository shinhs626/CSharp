using UnityEngine;

//ClassOne, ClassTwo 클래스를 사용
public class ClassDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //다른 클래스의 멤버 호출
        //[1] static 멤버 메서드 호출
        ClassOne.Hi();      //"안녕하세요"
        ClassTwo.Hi();      //"반갑습니다"

        //[2] instance 멤버 메서드 호출
        //인스턴스 생성
        ClassTwo Hello = new ClassTwo();        //유니티가 제공해주는 MonoBehaviour의 방식과는 다른 객체를 만드는 방식
        Hello.Hello();      //"또 만나요"
    }
}

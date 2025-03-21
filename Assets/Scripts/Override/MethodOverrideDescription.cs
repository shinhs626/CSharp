using UnityEngine;

namespace Override
{
    //Method Override(메서드 재정의, 메서드 오버라이드)
    //부모 클래스의 메서드를 재정의(다시 정의)해서 사용하기

    //abstract와 Override의 차이점은 무조건 자식 클래스 값을 사용해야하는게 abstract,
    //자신이 필요할때가 있어서 부모 값도 사용하고 자식 값도 사용해야 하는 경우 Override
    public class MethodOverrideDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Child 클래스의 인스턴스 생성
            Child child = new Child();
            child.Say();
            child.Run();
            child.walk();
        }
    }

}

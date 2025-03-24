using UnityEngine;

namespace Override
{
    public class Parent
    {
        public void Say() => Debug.Log("부모님 안녕하세요");
        public void Run() => Debug.Log("부모님 달린다");
        public virtual void walk() => Debug.Log("부모 걷다");
    }

    //자식 클래스
    public class Child : Parent
    {
        public new void Say() => Debug.Log("안녕하세요");
        public new void Run() => Debug.Log("달린다");      // virtual, abstract 이 없는 경우인데 자식클래스의 값으로 디버깅 하고 싶다면 new를 붙힌다
        public override void walk() => Debug.Log("걷다");
    }
}

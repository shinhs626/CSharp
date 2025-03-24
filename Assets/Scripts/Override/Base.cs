using UnityEngine;

namespace Override
{
    //부모 클래스
    public class Base
    {
        public virtual void Work() => Debug.Log("Base Class");
    }

    //자식 클래스
    public class Sub : Base
    {
        //sealed 키워드를 사용하여 재정의를 못하게 막을 수 있음
        //public override sealed void Work() => Debug.Log("Sub Class");
        public override void Work() => Debug.Log("Sub Class");
    }

    //손자 클래스
    public class GrandSub : Sub
    {
        //public void Play() => Debug.Log("Grand Class Play Game");
        public override void Work() => Debug.Log("GrandSub Class");
    }
}

using UnityEngine;

namespace InheritanceG 
{
    //부모 클래스
    public class Animal
    {
        public void Eat() => Debug.Log("밥을 먹어요");
    }

    //자식 클래스 : Animal
    // sealed : 클래스를 봉인(sealed) 클래스로 지정,
    // 최종 클래스가 되어 상속 불가능, 나를 부모로 지정하지 못하도록 막는다
    public sealed class Cat : Animal
    {

    }
    /*//자식 클래스 : Cat
    public class MyCat : Cat
    {
        //sealed 가 붙은 클래스는 부모로 지정 불가능
    }*/
}

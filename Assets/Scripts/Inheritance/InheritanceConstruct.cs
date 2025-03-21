using UnityEngine;

namespace InheritanceF
{
    public class InheritanceConstruct : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Child 클래스의 인스턴스 생성
            Child child = new Child();
            child.SayName();

            Child childSecond = new Child("백두산");
            childSecond.SayName();
        }
    }

}

using UnityEngine;

namespace Inheritance
{
    public class ObjectClass : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //정적(static) 메서드로 만들었기 때문에 (클래스이름.메서드) 이런 식으로 호출
            ChildClass.Hi();
            ChildClass.Bye();

            ParentClass parent = new ParentClass();
            Debug.Log(parent.ToString());

            ChildClass child = new ChildClass();
            Debug.Log(child.ToString());
        }
    }

}

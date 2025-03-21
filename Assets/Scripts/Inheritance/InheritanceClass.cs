using UnityEngine;

namespace InheritanceS
{
    public class InheritanceClass : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            ParentClass parent = new ParentClass();
            //parent.PrintMessage();    //protected로 선언하여서 메서드 실행 불가

            ChildClass child = new ChildClass();
            child.PrintMessageSecond(); //부모 클래스를 public 메서드로 가져와서 public 메서드에서 실행

            SubClass sub = new SubClass();
            sub.PrintDebug();
        }
    }

}
/*
public, private, protected
protected : 상속받은 자식, 클래스 코드 블록 안에서만 접근 가능, 사용 가능

public : 외부 클래스에서 접근, 사용 가능
private : 외부 클래스에서 접근, 사용 불가능
*/
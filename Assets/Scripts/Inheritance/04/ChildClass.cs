using UnityEngine;

namespace InheritanceS
{
    public class ChildClass : ParentClass
    {
        public void PrintMessageSecond()
        {
            PrintMessage();
            Debug.Log("위 내용은 부모 클래스에서 디버그 한 내용임");
        }
    }
}


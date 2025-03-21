using UnityEngine;

namespace InheritanceS
{
    public class ParentClass : System.Object
    {
        protected void PrintMessage()
        {
            Debug.Log("부모 클래스에서 정의한 내용 ");
        }
    }
}


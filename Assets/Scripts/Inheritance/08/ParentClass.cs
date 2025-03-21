using UnityEngine;

namespace InheritanceH
{
    //추상 클래스
    public abstract class ParentClass
    {
        public int Id { get; set; }
        public bool Active { get; set; }

    }

    //자식 클래스 : 추상 클래스 ()
    public class ChildClass : ParentClass
    {
        public string Name { get; set; }
    }
}

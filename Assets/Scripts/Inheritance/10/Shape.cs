using UnityEngine;

namespace InheritanceK
{
    //추상 클래스 : 도형을 관리하는 클래스
    //추상 메서드 기능 : 도형의 면적을 구하는 메서드 구현하도록 지정
    public abstract class Shape
    {
        //추상 메서드
        public abstract double GetArea();

    }

}

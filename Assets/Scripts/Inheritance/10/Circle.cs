using UnityEngine;

namespace InheritanceK
{
    //원을 관리하는 클래스
    //Shape(추상 클래스)를 상속 받는 자식 클래스
    public class Circle : Shape
    {
        //필드
        private int size;       //반지름

        //생성자
        public Circle(int size)
        {
            this.size = size;
        }

        //
        public override double GetArea()
        {
            return size * size * 3.14;
        }
    }
}


using UnityEngine;

namespace InheritanceK
{
    //정사각형을 관리하는 클래스
    //Shape(추상클래스)를 상속 받는 자식 클래스
    public class Squre : Shape
    {
        //필드
        private int size;       //한 변의 길이
        
        //생성자
        public Squre(int size)
        {
            this.size = size;
        }

        //부모 클래스의 추상 메서드를 구현
        public override double GetArea()
        {
            return size * size;
        }
    }
}


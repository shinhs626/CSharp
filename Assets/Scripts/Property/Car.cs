using UnityEngine;

namespace Property
{
    public class Car
    {
        //필드
        private string color;

        //[1] 필드 초기화 - 인스턴스를 생성하면서 생성자를 호출하여 초기화
        public Car()
        {
            this.color = "Black";
        }

        //[2] public 메서드를 통해서 color 접근
        public void SetColor(string color)
        {
            this.color = color;
        }

        public string GetColor()
        {
            return this.color;
        }

        //[3] public 속성을 통해서 color 값 접근
        public string Color
        {
            get
            {
                return this.Color;
            }
            set
            {
                this.color = value;
            }
        }

        //읽기 전용 속성
        public string Maker
        {
            get
            {
                return "현대자동차";
            }
        }

        //자동속성, 축약형
        public string Name { get; set; }
    }
}



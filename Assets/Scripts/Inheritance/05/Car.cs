using UnityEngine;

namespace InheritanceD
{
    public class Car
    {
        //필드
        private string name;

        //생성자 - 매개변수를 통해 name 초기화
        public Car(string name)
        {
            this.name = name;
        }

        //메서드
        public void Run() => Debug.Log($"{name}달린다");
    }
}

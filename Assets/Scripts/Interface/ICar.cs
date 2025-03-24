using UnityEngine;

namespace Interface
{
    //[1] ICar 인터페이스 정의
    public interface ICar
    {
        void Go();
    }

    //[2] ICar 인터페이스 구현
    public class Car : ICar
    {
        public void Go()
        {
            Debug.Log("출발");
        }
    }
}

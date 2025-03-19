using UnityEngine;

namespace Constructor
{
    public class Car
    {
        public Car()
        {
            Debug.Log("달린다");
        }
        //메서드
        public void Run(string color)
        {
            Debug.Log($"{color} 달린다");
        }
        ~Car()
        {
            Debug.Log("[3] 소멸");
        }
    }
}


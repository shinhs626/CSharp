using UnityEngine;

namespace Constructor
{
    public class ConstructorForwarding : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Money클래스의 인스턴스 생성
            Money yourMoney = new Money();

            //Money클래스의 매개변수가 있는 인스턴스 생성
            Money myMoney = new Money(1000000);
        }
    }
}


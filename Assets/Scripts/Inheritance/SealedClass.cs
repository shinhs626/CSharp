using UnityEngine;

namespace InheritanceG
{
    //Sealed(봉인) 클래스 : 최종 클래스, 더 이상 상속 되지 못하는 클래스
    public class SealedClass : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Cat cat = new Cat();
            cat.Eat();
        }
    }

}

using UnityEngine;

namespace Constructor
{
    public class ConstructorNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1]매개변수가 없는 생성자 호출
            Person my = new Person();
            string myName = my.GetName();
            Debug.Log(myName);

            //[2]매개변수가 있는 생성자 호출
            Person your = new Person("도깨비");
            string yourName = your.GetName();
            Debug.Log(yourName);
        }
    }
}


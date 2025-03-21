using UnityEngine;

namespace InheritanceF
{
    public class Child : Parent
    {
        //생성자
        public Child() : this("홍홍홍길길길동동동")
        {

        }
        public Child(string message) : base(message)
        {

        }

        public void SayName()
        {
            Debug.Log(base.Word);
        }
    }

}

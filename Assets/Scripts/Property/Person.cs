using UnityEngine;

namespace Property
{
    public class Person
    {
        //필드, 멤버변수
        private string name;

        //public한 property(속성)을 이용하여 private한 필드(name)에 접근
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //public한 메서드를 이용하여 private한 필드(name)에 접근
        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
    }
}


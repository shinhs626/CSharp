using UnityEngine;

namespace InheritanceD
{
    public class Your : Car
    {
        public Your() : base("너의 자동차")
        {

        }
        public Your(string name) : base(name)
        {

        }
    }
}


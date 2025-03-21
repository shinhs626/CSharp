using UnityEngine;

namespace InheritanceD
{
    public class My : Car
    {
        public My() : this("나의 자동차")
        {

        }
        public My(string name) : base(name)
        {
            
        }
    }

}

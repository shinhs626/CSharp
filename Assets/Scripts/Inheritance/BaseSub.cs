using UnityEngine;

namespace Inheritance
{
    public class BaseSub : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            SubClass sub = new SubClass();
            sub.Do();
            sub.Did();
        }
    }

}

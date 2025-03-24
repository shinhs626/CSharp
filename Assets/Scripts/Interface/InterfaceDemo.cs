using UnityEngine;

namespace Interface
{
    public class InterfaceDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Cry();
        }
    }

}

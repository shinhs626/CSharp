using UnityEngine;

namespace InheritanceJ
{
    public class InheritanceMustDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Person
            Person person = new Person();
            person.SayTalk();
        }
    }

}

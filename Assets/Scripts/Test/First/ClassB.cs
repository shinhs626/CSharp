using UnityEngine;

namespace Test
{
    public class ClassB : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1] 월,화,수,목,금,토
            ClassA firstQuest = new ClassA();
            firstQuest.Instance();

            //[2] 11
            int secondQuest = ClassA.Static(5, 6);
            Debug.Log(secondQuest);
        }
    }

}

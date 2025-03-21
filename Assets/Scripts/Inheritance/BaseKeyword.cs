using UnityEngine;

namespace InheritanceD
{
    public class BaseKeyword : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            My my = new My();
            my.Run();
            Your your = new Your();
            your.Run();
        }
    }
}


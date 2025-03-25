using UnityEngine;
using System.Linq;

namespace TestTwo
{
    public class ClassA : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            int[] min = { -2, -5, -3, -7, -1 };
            int minValue = min.Min();

            Debug.Log(minValue);
        }
    }

}

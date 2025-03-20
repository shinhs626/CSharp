using UnityEngine;

namespace Delegate
{
    public class CarDriver
    {
        public static void GoForward()
        {
            Debug.Log("직진");
        }

        public static void GoLeft()
        {
            Debug.Log("좌");
        }

        public static void GoRight()
        {
            Debug.Log("우");
        }
    }

}

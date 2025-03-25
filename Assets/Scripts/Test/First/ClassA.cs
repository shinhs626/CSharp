using UnityEngine;

namespace Test
{
    public class ClassA
    {
        private string[] day = {"일","월","화","수","목","금","토"};

        public void Instance()
        {
            for (int i = 0; i < day.Length; i++)
            {
                Debug.Log(day[i]);
            }
        }

        public static int Static(int a, int b)
        {
            return a + b;
        }
    }

}

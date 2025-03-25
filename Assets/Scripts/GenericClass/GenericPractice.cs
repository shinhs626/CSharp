using UnityEngine;

namespace GenericClass
{
    public class GenericPractice : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1] int
            MyList<int> myListInt = new MyList<int>(3);
            myListInt[0] = 10;
            myListInt[1] = 20;
            myListInt[2] = 30;

            for (int i = 0; i < myListInt.Length; i++)
            {
                Debug.Log(myListInt[i]);
            }

            //[2] string
            MyList<string> myListString = new MyList<string>(3);
            myListString[0] = "홍";
            myListString[1] = "길";
            myListString[2] = "동";

            for (int i = 0; i < myListString.Length; i++)
            {
                Debug.Log(myListString[i]);
            }
        }
    }

}

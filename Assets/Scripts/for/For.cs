using UnityEngine;

//1부터 5까지 1씩 증가하면서 값을 출력하는 프로그램
//Count: 1
//Count: 2
//Count: 3
//Count: 4
//Count: 5

public class For : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]
        for (int i = 0; i < 5; i++)
        {
            Debug.Log($"Count:{i + 1}");
        }

        //[2]
        /*
        for(int i = 1; i<=5; i++)
        {
            Debug.Log($"Count:{i}");
        }
        */

        //[3]
        /*
        for(int i = 1; i < 6; i++)
        {
            Debug.Log($"Count:{i}");
        }
        */
        

    }
}

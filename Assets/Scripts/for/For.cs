using UnityEngine;

//1���� 5���� 1�� �����ϸ鼭 ���� ����ϴ� ���α׷�
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

using UnityEngine;

//1���� 10������ ���� �� ¦���� ���� ���ϴ� ���α׷� ����
public class ForSumEven : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 10;
        int sum = 0;

        for(int i = 1; i < n+1; i++)
        {
            if(i % 2 == 0)
            {
                //¦���� ���Ѵ�
                sum = sum + i;
            }
        }
        Debug.Log($"1���� 10������ ¦���� ���� {sum}�Դϴ�.");
    }
}

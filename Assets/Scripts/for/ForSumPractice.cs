using UnityEngine;

public class ForSumPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 100;
        int sum = 0;

        for(int i = 1; i < n + 1; i++)
        {
            if(i % 3 == 0 || i % 4 == 0)
            {
                sum = sum + i;
            }
        }
        Debug.Log($"���� ����{sum}");
    }
}
/*
[Q]
1���� 100������ �����߿��� 3�� ��� �Ǵ� 4�� ����� ���ؼ� ���ϴ� ���α׷�
*/
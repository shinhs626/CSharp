using UnityEngine;

//1���� 20������ ���� ���ϴ� ���α׷� ����
public class ForSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1���� n������ ���� ���ϴ� ���α׷� ����
        int n = 100;
        int sum = 0;

        for(int i = 1; i < n+1; i++)
        {
            sum = sum + i;
        }
        Debug.Log($"1���� 20������ ���� {sum}�Դϴ�.");
    }
}

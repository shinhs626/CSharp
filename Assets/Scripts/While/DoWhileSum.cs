using UnityEngine;

//doWhile���� �̿��ؼ� 1���� n(100)������ ���� �߿��� ¦���� ���� ���ϴ� ���α׷� ����
public class DoWhileSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 100;
        int sum = 0;

        int i = 0;

        do
        {
            if (i % 2 ==0)
            {
                sum = sum + i;
            }
            i++;
        } while (i < n+1);

        Debug.Log($"1���� {n}������ ���� �߿��� ¦���� ���� {sum}�Դϴ�");
    }
}

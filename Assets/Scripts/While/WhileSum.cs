using UnityEngine;

//while���� �̿��ؼ� 1���� 100���� ���� ���ϴ� ���α׷�
public class WhileSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 0;
        int n = 100;
        int sum = 0;

        while(i < n)
        {
            sum = sum + (i+1);
            i++;
        }
        Debug.Log($"1���� {n}������ ���� {sum}�Դϴ�");
    }
}

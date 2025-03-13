using UnityEngine;

public class TryCatchDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        try
        {
            int[] arr = new int[2];
            arr[1] = 10;
        }
        catch
        {
            Debug.Log("�����߻�");
        }
    }
}

/*
���� ó��(Exception Handling)   :   try-catch-finally ���� ���
����(����, ����)
-   ���� ����                   �ڵ� ����
-   ��Ÿ�� ����                  ������ ���������� ��)����Ƽ ���� ��ư�� ���� �ڿ� �����߿� ������ ����
-   �˰��� ����                 ���α׷����� �ǵ���� ������� �ʴ� ����

����
try
{
    //��ɹ�
}
catch
{
    //try �ڵ��� �ȿ� �ִ� ��ɹ����� ������ ����(Exception) �߻��� ó���� ����
}
*/
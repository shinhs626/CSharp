using UnityEngine;

//�� ���� ������ ���̸� ���� ������ ���ϼ���
public class NumDifference : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int first = -3;
        int second = -8;
        int diff = 0;       //�μ��� ���̰�

        if(first >= second)
        {
            diff = first - second;
        }
        else
        {
            diff = second - first;
        }
        Debug.Log($"�� ���� ���̴� {diff}�Դϴ�.");
    }
}

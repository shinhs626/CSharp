using UnityEngine;

public class FunctionMaxMin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int MaxResult = GetMax(3, 5);
        Debug.Log($"3�� 5�� ū ���� {MaxResult}�Դϴ�");

        int MinResult = GetMin(-3, -5);
        Debug.Log($"-3�� -5�� ���� ���� {MinResult}�Դϴ�");

    }

    int GetMax(int x, int y)
    {
        /*int MaxValue;
        if(x > y)
        {
            MaxValue = x;
        }
        else
        {
            MaxValue = y;
        }
        return MaxValue;*/

        //3�� ������
        int MaxValue = (x > y) ? x : y;
        return MaxValue;
    }
    int GetMin(int x, int y)
    {
        /*int MinValue;
        if (x > y)
        {
            MinValue = y;
        }
        else
        {
            MinValue = x;
        }
        return MinValue;*/

        int MinValue = (x < y) ? x : y;
        return MinValue;
    }
}
/*
[Q]
1. �Ű������� �Է� ���� �� ���� ���� �� ū���� ��ȯ�ϴ� �Լ�
2. �Ű������� �Է� ���� �ΰ��� ������ ���� ���� ��ȯ�ϴ� �Լ�
3. 3, 5�� �Է¹޾� ū ���� ����ϱ�
4. -3, -5�� �Է¹޾� ���� ���� ����ϱ�

[output]
3�� 5�� ū ���� (��ȯ��)�Դϴ�
-3�� -5�� ���� ���� (��ȯ��)�Դϴ�
*/
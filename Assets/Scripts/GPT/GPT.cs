using System;
using UnityEngine;

public class GPT : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ������ ���ڵ�
        int[] numbers = { 5, 3, 6, 8, 9 };

        // �ּڰ��� ������ ���� ����, �ʱⰪ�� �ִ밪���� ����
        int minValue = int.MaxValue;

        // �迭 ���� ���ڵ��� ���������� Ȯ���Ͽ� �ּڰ��� ã��
        foreach (int number in numbers)
        {
            // ���� ���ڰ� �ּڰ����� ������ �ּڰ��� ����
            if (number < minValue)
            {
                minValue = number;
            }
        }

        // �ּڰ� ���
        Debug.Log($"�ּڰ��� : {minValue}�Դϴ�");
    }
}

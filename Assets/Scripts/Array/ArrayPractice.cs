using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[,] intArray = new int[3,3];

        for(int i = 0; i < intArray.GetLength(0); i++)
        {            
            for (int j = 0; j < intArray.GetLength(1); j++)
            {
                if (i == j)
                {
                    intArray[i, j] = 1;
                }
                else
                {
                    intArray[i, j] = 0;
                }
                Debug.Log($"arr[{i},{j}] : {intArray[i, j]}");
            }
        }
    }
}
/*
[Q]
3�� 3���� 2���� �迭�� ����� ���� �����ϴµ�
��� ���� �ε����� ������ 1, ��� ���� �ε����� Ʋ���� 0���� �����ϼ���


*/
using UnityEngine;

public class ArrayTwoSecond : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //2���� �迭 ����, ��Ҽ� ����, �ʱ�ȭ
        //int[,] intArray = new int[2, 3] {{1,2,3}, {4,5,6}};
        //2���� �迭 ����, ��Ҽ� ����, �ʱ�ȭ
        //int[,] intArray = new int[,] {{1,2,3}, {4,5,6}};

        int[,] intArray = { { 1,2,3}, {4,5,6 } };

        //�迭�� ����
        //Debug.Log(intArray.Length);

        //���

        for (int i = 0;  i < intArray.GetLength(0); i++)
        {
            for (int j = 0; j < intArray.GetLength(1); j++)
            {
                Debug.Log(intArray[i, j]);
            }
        }
    }
}

using UnityEngine;


//1���� �迭�� �����ϰ� �ʱ�ȭ
public class ArrayOne : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 1���� �迭 ����
        int[] intArray;

        //[2] �迭�� ��Ҽ� ���� -> ũ�� ����, �޸� ���� Ȯ��
        intArray = new int[3];

        //[3] �迭�� �ʱ�ȭ
        intArray[0] = 1;
        intArray[1] = 2;
        intArray[2] = 3;

        //[4] �迭�� ���
        //Debug.Log($"0��° ��: {intArray[0]}, 1��° ��: {intArray[1]}, 2��° ��: {intArray[2]}");

        for(int i = 0; i < 3; i++)
        {
            Debug.Log($"{i}��° ��: {intArray[i]}");
        }
    }
}

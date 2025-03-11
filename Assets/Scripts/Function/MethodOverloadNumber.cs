using UnityEngine;

//MethodOverload(�޼��� �����ε�, �Լ� ���� ����)
//������ �̸��� �޼��带 �Ű� ������ �ٸ��� �ؼ� ���� �� �����ϴ� ��
public class MethodOverloadNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintNumber(1234);
        PrintNumber(1234L);
        PrintNumber(1234F);
    }

    //�Լ� ���� ����

    //�Ű� ������ ���ڸ� �Է� �޾� ����ϴ� �Լ�
    //int Ÿ���� ������ �Ű� ������ �Է� �޾� ���
    void PrintNumber(int num)
    {
        Debug.Log($"int32: {num}");
    }

    //long Ÿ���� ������ �Ű� ������ �Է� �޾� ���
    void PrintNumber(long num)
    {
        Debug.Log($"int64: {num}");
    }

    //float Ÿ���� ������ �Ű� ������ �Է� �޾� ���
    void PrintNumber(float num)
    {
        Debug.Log($"�Ǽ���: {num}");
    }

}

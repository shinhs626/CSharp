using UnityEngine;

public class FunctionPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(Add(5, 3));
        Debug.Log(Subtract(5, 3));
        Debug.Log(Multiply(5, 3));
        Debug.Log(Devide(5, 3));
        Debug.Log(Remainder(5, 3));
    }

    int Add(int x, int y)
    {
        return x + y;
    }
    int Subtract(int x, int y)
    {
        return x - y;
    }
    int Multiply(int x, int y)
    {
        return x * y;
    }
    int Devide(int x, int y)
    {
        return x / y;
    }
    int Remainder(int x, int y)
    {
        return x % y;
    }
}
/*
[Q]
��Ģ������ ���ϴ� �Լ� �����
�� ���� ������ �Է¹޾� +, -, *, /, % ����Ͽ�
������� ��ȯ�ϴ� �Լ� �����
*/
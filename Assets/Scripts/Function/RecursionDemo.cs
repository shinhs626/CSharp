using UnityEngine;

//���丮�� ���ϴ� �˰���(4!)

public class RecursionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //4! = 1 * 2 * 3 * 4
        Debug.Log(4 * 3 * 2 * 1);

        //For Factorial
        Debug.Log(FactorialFor(4));

        Debug.Log(Factorial(8));

        Debug.Log(Factor(4));
    }

    //3�� �����ڸ� �̿��� Factorial �����
    int Factor(int n)
    {
        //if (n <= 1) return 1;
        //return n * Factor(n - 1);

        return (n > 1) ? n * Factor(n - 1) : 1;
    }

    //For�� �̿� Factorial �� ���ϱ�
    int FactorialFor(int n)
    {
        int result = 1;

        if (n < 0)
        {
            // ������ ���� ���丮���� ���ǵ��� �����Ƿ� ���� �� ��ȯ
            // ���� ��� �ÿ��� ���� ó���� �߰��ϴ� ���� �����ϴ�
            return -1; // �Ǵ� ���� �ڵ�
        }
        else if (n == 0)
        {
            // 0! = 1
            return 1;
        }
        else
        {
            // ����� ���� ���丮�� ���
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }
    }

    //����Լ� �̿��� Factorial �� ���ϱ�
    int Factorial(int n)
    {
        if(n == 1 || n == 0)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
            
    }
}

/*
����Լ� : �Լ��� �ڽ��� �ڵ� ��� �ȿ��� �ڱ� �ڽ��� �ٽ� ȣ��(��� ȣ��)�ϴ� �Լ�
-����Լ� �Ű� ����: �Ű� ������ ����, ������ �ȴ�
-����Լ� �ڵ� ��Ͼȿ��� ����Լ��� ���� �� �� �ִ� ������ �ʿ��ϴ�

*/
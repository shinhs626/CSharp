using UnityEngine;

public class ElseNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (1 != 1)
        {
            //Debug.Log("1�� 1�� ���� �ʽ��ϴ�");
        }
        else
        {
            Debug.Log("1�� 1�� �����ϴ�");
        }
    }
}

/*
else ��
���� ���ǽ��� ���̶�� ���๮1 ���� �����̶�� ���๮2 ����


if(���ǽ�)
{
    //���ǽ��� ���� �� ���๮1(��ɹ�)�� ����
}
else
{
    //���ǽ��� ������ �� ���๮2(��ɹ�)�� ����
}

//���๮3

1.���ǽ��� ���̸� ���๮1�� �����ϰ� ���๮3�� ����
2.���ǽ��� �����̸� ���๮2�� �����ϰ� ���๮3�� ����
*/
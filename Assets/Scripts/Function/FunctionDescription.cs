using UnityEngine;

public class FunctionDescription : MonoBehaviour
{
    //[1]show �޼���(�Լ�)
    void Show()
    {
        Debug.Log("Hello World");
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()//�Ű������� ���� �Լ�, ����Ƽ���� �����ϴ� ���� �Լ�
    {
        //[2] show�Լ� ȣ��
        Show();
    }
}
/*
Function(�Լ�) / Method(�޼���)
:�ݺ��ؼ� ����ϵ��� ������� �ϳ� �̻��� ��ɹ����� ������ �ڵ���

-���� �Լ�:���(C#)���� �����ϴ� �Լ�, ����Ƽ���� �����ϴ� �Լ�
-����� �Լ�: �����ڰ� ����� �Լ�

-�Ű������� ���� �Լ�
-�Ű������� �ִ� �Լ�
-��ȯ���� �ִ� �Լ�

void �Լ��̸�()
{
    //�ϳ� �̻��� ��ɹ�
}

void �Լ��̸�(�Ű�����)
{
    //�ϳ� �̻��� ��ɹ�
}

(������ Ÿ��) �Լ��̸�()
{
    //�ϳ� �̻��� ��ɹ�

    return ����(��);
}

//�Լ� ����
�Է� -> ó��(����) -> ���

//�Լ�(�޼���)
[1] �Լ� ����(��� ����)
[2] �Լ� ȣ��(��� ���)
*/
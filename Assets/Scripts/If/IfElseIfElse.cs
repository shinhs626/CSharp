using UnityEngine;

public class IfElseIfElse : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //number1, number2 ���� �Է¹޾Ƽ�
        //[1] number1�� ũ�� number1�� ũ�ٶ�� ���
        //[2] number2�� ũ�� number2�� ũ�ٶ�� ���
        //[3] �� �� ������ �� �� ���ٶ�� ���

        int number1 = 10;
        int number2 = 10;

        if (number1 > number2)
        {
            Debug.Log("number1�� ũ��");
        }
        else if (number1 < number2)
        {
            Debug.Log("number2�� ũ��");
        }
        else
        {
            Debug.Log("�� �� ����");
        }
    }
}

/*
Else If ��

[1]���ǽ� 1�� ���̸�
���� -> ���๮1 -> ���๮4

[2]���ǽ� 1�� �����̰� ���ǽ� 2�� ���̸�
���� -> ���๮2 -> ���๮4

[3]���ǽ� 1, 2�� �����̸�
���� -> ���๮3 -> ���๮4

[4]���ǽ�1�� ���̰�, 2�� ���̸�
���� -> ���๮1 -> ���๮4

*/
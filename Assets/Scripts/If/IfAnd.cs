using UnityEngine;

//&&, ||
public class IfAnd : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number = 1234;

        //���ǽ� 2�� : number�� 1234�� ����?, number�� 1000���� ũ�ų� ����?
        //2���� ���ǽ��� ��� �����ϸ�(&&) �½��ϴ� ���
        if (number == 1234 && number >= 1000)
        {
            Debug.Log("�½��ϴ�");
        }

        //���ǽ� 2�� : number�� 1234�� ����?, number�� 1000���� �۰ų� ����?
        //2���� ������ �ϳ��� �����ϸ�(||) ���๮(��ɹ�)�� ����
        if(number == 1234 || number <= 1000)
        {
            Debug.Log("number�� 1234�̰ų� 1000���� �۰ų� �����ϴ�");
        }
    }
}

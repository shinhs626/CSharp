using UnityEngine;
using System.Collections;

public class StackNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] Stack Ŭ������ �ν��Ͻ�(�ν��Ͻ�,��ü) ����
        Stack stack = new Stack();

        //[2] Push�� ������ ����
        stack.Push("���ѹα�");
        stack.Push("����");
        stack.Push("��⵵");

        //[3] ������ ���� ���(������)�� �����͸� ��ȯ
        Debug.Log($"{stack.Peek()}{stack.Count}");

        //[4] Pop() ���ÿ��� ������ ������
        stack.Pop();

        //[5] ������ ���� ���(������)�� �����͸� ��ȯ
        Debug.Log($"{stack.Peek()}{stack.Count}");

        if(stack.Count > 0)
        {
            //[6] 0���� Ŭ���� Pop() ���ÿ��� ������ ������
            stack.Pop();
        }

        //[7] ������ ���� ���(������)�� �����͸� ��ȯ
        stack.Clear();
    }
}

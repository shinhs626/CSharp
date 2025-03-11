using UnityEngine;

public class MethodOverloadDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Hi();
        Hi("�ȳ��ϼ���");
        Hi("�ȳ��ϼ���",5);
    }

    //�λ��ϴ� �Լ�
    //�Ű������� ���� �Լ�
    void Hi()
    {
        Debug.Log("�ȳ��ϼ���");
    }
    
    //�Ű� ������ �Է� ���� (msg)�� �λ��ϴ� �Լ�
    void Hi(string msg)
    {
        Debug.Log(msg);
    }

    //�Ű� ������ �Է� ���� (msg)�� �Ű� ������ ���� (count) Ƚ�� ��ŭ �λ�
    void Hi(string msg, int count)
    {
        for(int i = 0; i < count; i++)
        {
            Debug.Log(msg);
        }
    }
}

using UnityEngine;

//  Variable(����) : ���α׷����� ����ϴ� �����͸� ������ ���� �׸�
public class VariableNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ������ �����(������ �����Ѵ�)
        int i; //i �̸����� (������)������ �����

        //[2] ������ ���� �����Ѵ�(����, �Ҵ�, �ʱ�ȭ)
        i = 1234;
        
        //[3] ������ ����ִ� ���� ����Ѵ�(����)
        Debug.Log(i);
    }
}

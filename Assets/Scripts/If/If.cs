using UnityEngine;

//���� score�� 60�� �̻��̸� "�հ�" �̶�� ���,
//score 61��
public class If : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 61;

        if (score >= 60) //���ǽ��� ���̸� ����
        {
            Debug.Log("�հ�"); //���๮
        }
    }
}

/*
if�� - ���ǹ�
���ǽ��� ���϶��� ���๮�� ����˴ϴ�.
���ǽ��� �����̸� ���๮�� �������� �ʽ��ϴ�

//���� ���ǽ��� ���̸� { }�ȿ� �ִ� ���๮�� �����Ѵ�.
if(���ǽ�)
{
    //���๮1
    //���๮2
    //...
}
if(bool)
{
    //���๮1
    //���๮2
    //...
}
*/
using UnityEngine;

public class WhileDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        for(int i = 0; i < 3; i++)
        {
            Debug.Log("�ȳ��ϼ���");
        }
        */
        /*
        for(int i = 1; i < 4; i++)
        {
            Debug.Log("�ȳ��ϼ���");
        }
        */
        /*
        for(int i = 0; i <= 3; i++)
        {
            Debug.Log("�ȳ��ϼ���");
        }
        */
        int i = 0;

        while (i < 3)
        {
            Debug.Log($"�ȳ��ϼ��� i�� {i+1}�Դϴ�");
            i++;
        }

        //���ǽ� �Ǻ�(i:0) �� -> �ݺ��� ���� -> ������ -> ���ǽ� �Ǻ�(i:1) �� -> �ݺ��� ���� -> ������
        //-> ���ǽ� �Ǻ�(i:2) �� -> �ݺ��� ���� -> ������ -> ���ǽ� �Ǻ�(i:3) ���� -> while�� ����
    }
}
/*
while�� - �ݺ���
���ǽ��� true�̸� �ݺ����� ���� false�̸� while���� ����

while(���ǽ�)
{
    //�ݺ� ���๮

    //���ǽ��� ���� ������
}

���ǽ� �Ǻ�(��) -> �ݺ��� ���� -> ���ǽ� �Ǻ�(��) -> �ݺ��� ���� -> ���ǽ� �Ǻ�(����) -> while�� ����

*/
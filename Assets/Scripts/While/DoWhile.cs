using UnityEngine;

public class DoWhile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 0;

        do
        {
            Debug.Log("�ȳ��ϼ���");
            i++;
        } while (i < 3);
        
    }
}

/*
DoWhile �� - �ݺ���
���� �ݺ� ���๮�� 1�� �����Ѵ�
���ǽ��� true�̸� �ݺ����� �����Ѵ�
���ǽ��� false�̸� while���� �����Ѵ�

do 
{
    //�ݺ� ���๮
}   while(���ǽ�)

*/
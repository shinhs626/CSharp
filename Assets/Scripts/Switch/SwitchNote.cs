using UnityEngine;

public class SwitchNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ����
        int x = 3;

        //[2] switch��
        switch (x)// x�� ���� ���� case�� ����
        {
            case 1:
                Debug.Log("1�Դϴ�.");//[2] ���๮1
                break;
            case 2:
                Debug.Log("2�Դϴ�.");//[3] ���๮2
                break;
            case 3:
                Debug.Log("3�Դϴ�.");//[4] ���๮3
                break;
            default:
                Debug.Log("1, 2, 3�� �ƴմϴ�.");
                break;
        }
        Debug.Log("���α׷� ����");//[5] ���๮4

        //int x = 1;
        //[1] -> [2] -> [5]
        //int x = 2;
        //[1] -> [3] -> [5]
        //int x = 3;
        //[1] -> [4] -> [5]
        //int x = 4;
        //[1] -> [5]
    }
}
/*
switch�� : ���ǹ� - ���ù�

switch(����) : Data �� �Ǻ�
{
    case 1 : ������ 1�� �� ����
    {
        ���๮1
        break;
    }
    case 2 : ������ 2�� �� ����
    {
        ���๮2
        break;
    }
    case 3 : ������ 3�� �� ����
    {
        ���๮3
        break;
    }
    default : ������ 1, 2, 3�� �ƴ� �� ����
    {
        ���๮4
        break;
    }
}


if(���ǽ�) : ���ǽ��� ���� �� ����
{
    ���๮1
}
else : ���ǽ��� ������ �� ���� 
{
    ���๮2
}
*/
using UnityEngine;

//�μ��� ���� ���ϴ� �Լ� �����
public class GetSumTwoNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2]�� ������ ���� ��ȯ���� �޾� ����ϱ�
        int returnValue = GetSum(5, 10);
        Debug.Log(returnValue);
    }

    //[1] �μ��� ���� ���ϴ� �Լ� ����� - �Ű�����, ��ȯ�� �̿�
    //�Ű������� ���� �� ������ ���� ��ȯ�ϴ� �Լ� ����
    int GetSum(int x,int y)
    {
        //int sum = x + y;
        //return sum;

        return (x + y);
    }
}

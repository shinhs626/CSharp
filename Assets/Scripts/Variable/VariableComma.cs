using UnityEngine;

//�޸��� ����Ͽ� ���� ������ ������ ���� ���� ������ �����
public class VariableComma : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ���� number1,2,3 ����

        //int number1;
        //int number2;
        //int number3;

        int number1, number2, number3;

        //[2] ������ ���� ����(�Ҵ�)
        number1 = 1;
        number2 = 2;
        number3 = 3;

        //[3] ���� ���(����)
        Debug.Log(number1+","+number2 + "," + number3);
    }
}

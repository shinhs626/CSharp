using UnityEngine;

public class ConstantNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //����
        string name = "ȫ�浿";
        name = "������";                //�����̱� ������ ���� ������

        //���
        const int AGE = 20;             //20���� ���̸� ����(const ���)
        //AGE = 21;                     //����̱� ������ ���� �Ұ�����

        //����, ��� ���
        Debug.Log($"{name} - {AGE}");

    }
}

using UnityEngine;

// = : AssignmentOperator(�Ҵ�(����) ������) - ������ ���� �����ϴ� ������
public class AssignmentOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string name = "ȫ�浿"; //����,����,�Ҵ�,�ʱ�ȭ
        int age = 19;

        Debug.Log($"�̸��� {name}, ���̴� {age}�Դϴ�");
    }
}

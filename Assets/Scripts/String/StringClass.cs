using UnityEngine;

//string == System.String
//���ڿ� ���� ���ϱ�
public class StringClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string s1 = "�ȳ��ϼ���";
        System.String s2 = "�ݰ����ϴ�.";

        Debug.Log($"{s1}���� - {s1}, {s2}�� ���� {s2.Length}");
    }
}

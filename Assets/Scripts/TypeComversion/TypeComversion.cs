using UnityEngine;

public class TypeComversion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //double�� �Ǽ��� ������ d�� �����ϰ� 12.34�� �ʱ�ȭ
        double d = 12.34; //
        //int�� ������ ������ i�� �����ϰ� 1234�� �ʱ�ȭ
        int i = 1234;

        //[1]double > int : ������(�Ϲ���,�Ͻ���) ����ȯ
        d = i;
        Debug.Log($"�Ϲ��� ����ȯ:{d}");

        d = 12.34;
        i = 1234;

        //[2]int < double : ����� ����ȯ �ʿ�
        i = (int)d;// ():ĳ���� ������
        Debug.Log($"�����1 ����ȯ:{i}");

        //[3]�ٸ� ���İ��� ��ȯ
        string s = "";//string ���� s�� �����ϰ� ""(�� ��)���� �ʱ�ȭ
        s = d.ToString();//ToString() �޼���� double�� ���� d�� string������ ��ȯ
        Debug.Log($"�����2 ����ȯ:{s}");
    }
}

using UnityEngine;

//GetType : ������ Ÿ�� �о����
public class GetTypeDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 1234;                   //������ int
        double d = 3.14;                //�Ǽ��� double
        string s = "�ȳ��ϼ���";        //���ڿ� string
        char c = 'A';                   //������ char

        Debug.Log(i.GetType()); //System.Int32
        Debug.Log(d.GetType()); //System.Double
        Debug.Log(s.GetType()); //System.String
        Debug.Log(c.GetType()); //System.Char
    }
}

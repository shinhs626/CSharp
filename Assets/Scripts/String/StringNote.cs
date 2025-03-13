using UnityEngine;

public class StringNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //string ���� �����ϰ� �� ������ �ʱ�ȭ
        string str = "";
        str = System.String.Empty;  //�� ������ ����(null �ƴ�)
        str = " Abc Def Fed Cba ";  //�� �ڿ� ���� �ϳ� �� �־ �� ����
        
        Debug.Log(str);
        Debug.Log(str.Length);  //���ڿ� ���� ���ϱ�
        Debug.Log(str[5]);      //���� D ����ϱ�
        Debug.Log(str.ToUpper()); //���� �빮�ڷ� ����ϱ�
        Debug.Log(str.ToLower()); //���� �ҹ��ڷ� ����ϱ�

        //���� ���� ���
        Debug.Log(str.Trim());  //���� ��,�� ���� �޼���
        Debug.Log(str.TrimStart()); //���ڿ� �տ� ���� ���� �޼���
        Debug.Log(str.TrimEnd());   //���ڿ� �ڿ� ���� ���� �޼���

        //�˻�
        Debug.Log(str.IndexOf('e'));    //'e'�� ��ġ�� �ε��� ��������
        Debug.Log(str.Substring(5,3)); //5�� �ε��� ���� 3���� ��������
        Debug.Log(str.Substring(5)); //5�� �ε������� ������ ��������
        Debug.Log(str.Remove(5,3)); //5�� �ε������� 3���� ����
        Debug.Log(str.Remove(5));   //5�� �ε������� ������ ����

        //��
        Debug.Log(str[1] == str[15]);   //false
        Debug.Log("ABC".Equals("Abc")); //false
        Debug.Log(System.String.Compare("BAC", "Bac")); // 0(����), 1(�ٸ� >), -1(�ٸ� < ) 

        //����
        var hi1 = "�ȳ�";
        var hi2 = "�ϼ���";

        Debug.Log(hi1 + hi2);
        Debug.Log($"{hi1}{hi2}");
        Debug.Log(System.String.Format("{0}{1}",hi1,hi2));

        //format
        Debug.Log(System.String.Format("{0:C}", 1000));  //C : ��ȭ��
        Debug.Log(System.String.Format("{0:#,###}", 1000000));  //�� �ڸ� �޸�

        //�и��ϱ� - ���ڿ� ��ü ���� ����
        string[] strArray = str.Trim().Split(' ');
        string strAll = "";
        foreach (var s in strArray)
        {
            //Debug.Log(s);
            strAll = strAll + s;
        }
        Debug.Log(strAll);
    }
}

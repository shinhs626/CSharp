using UnityEngine;

//TypeComversionError (���ĺ�ȯ)
public class TypeComversionError : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] long�� ���� err�� �����ϰ� long�� ������ ���� �� �ִ� �ִ밪�� �ʱ�ȭ
        long err = long.MaxValue;

        
        Debug.Log($"err�� ��: {err}");//err���� �ܼ�â�� ���

        //[2] int�� ���� Err�� �����ϰ� err���� �Ҵ�
        int Err = (int)err;
        Debug.Log($"Err�� ��: {Err}");
    }
}

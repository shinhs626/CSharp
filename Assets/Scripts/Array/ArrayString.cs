using UnityEngine;

public class ArrayString : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1-1]
        //string[] stringArray = new string[4] { "��", "��","��","��" };
        //[1-2]
        //string[] stringArray = new string[] { "��", "��","��","��" };
        //[1-3]
        //string[] stringArray = { "��", "��", "��", "��", "��", "��" };

        //���ڿ��� ���ڷ� �� �� �̱� ������ ���ڷ� �� �迭��
        string arr = "C#8";

        Debug.Log(arr.Length);

        Debug.Log(arr[0]);
        Debug.Log(arr[1]);
        Debug.Log(arr[2]);

    }
}

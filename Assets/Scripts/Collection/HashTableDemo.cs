using UnityEngine;
using System.Collections;

//HashTable : ���� ����, ���ڿ� ������ �ε����� ����Ͽ� ������(��)���� ����, �����ϴ� Ŭ����
// [0], [1], [2], ["���ڿ�"], ["�̸�"]
public class HashTableDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] HashTable Ŭ������ �ν��Ͻ�(��ü,��ü)�� ����
        Hashtable hash = new Hashtable();

        //[2] ������ �ֱ� : �ε��� ���
        hash[0] = "���ѹα�";
        hash["��"] = "��⵵";
        hash["���"] = "�ƽþ�";

        //[3] ������ ���
        /*for (int i = 0; i < hash.Count; i++)
        {
            Debug.Log(hash[i]);
            Debug.Log(hash["��"]);
            Debug.Log(hash["���"]);
        }*/

        foreach(var i in hash.Keys)
        {
            Debug.Log(hash[i]);
        }
    }
}

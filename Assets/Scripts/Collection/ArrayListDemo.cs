using UnityEngine;
using System.Collections;

public class ArrayListDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ArrayList Ŭ������ �ν��Ͻ�(��ü, ��ü) ����
        ArrayList list = new ArrayList();

        //[2] ������ ���� : Add()
        list.Add("����Ư����");
        list.Add("������");

        //[3] ������ ���
        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log(list[i].ToString());
        }
    }
}
/*
ArrayList Ŭ���� : �迭�� ���� ������ ������ ����, �迭ó�� ����� ����(�ε��� ���)

Add() ������ �ֱ�
*/
using UnityEngine;

//������ ���� �������̳� ���ڿ��� ����� ����
enum Animals
{
    Dog,
    Pig,
    Cat,
}

public class EnumIndex : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //������ ���� �����ϰ� �ʱ�ȭ
        Animals animal = Animals.Cat;
        int num = (int)animal;
        string str = animal.ToString();

        Debug.Log($"{num} - {str}");
    }
}

using UnityEngine;

public class IfElseAll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //�ϳ��� ������ �Է� �޾Ƽ� ¦���̸� "¦���Դϴ�", Ȧ���̸� "Ȧ���Դϴ�"�� ���
        //¦���� Ȧ���� �ƴ� ��� "¦���� Ȧ���� �ƴմϴ�."�� ���

        int number = 42;

        if(number % 2 == 0)//¦�� �Ǻ���
        {
            Debug.Log("¦���Դϴ�.");
        }
        else if(number % 2 != 0)//Ȧ�� �Ǻ���
        {
            Debug.Log("Ȧ���Դϴ�.");
        }

        //3�� ��� �Ǻ���
        if (number % 3 == 0)
        {
            Debug.Log($"{number}�� 3�� ����Դϴ�.");
        }
        else if(number % 5 == 0)
        {
            Debug.Log($"{number}�� 5�� ����Դϴ�.");
        }
        else if(number % 7 == 0)
        {
            Debug.Log($"{number}�� 7�� ����Դϴ�.");

        }
        else
        {
            Debug.Log($"{number}�� 3, 5, 7�� ����� �ƴմϴ�.");
        }
    }
}

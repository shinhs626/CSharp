using UnityEngine;

public class ElseIf : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //score�� 90�� �̻��̸� A����, 80�� �̻��̸� B����, 70�� �̻��̸� C����, 60�� �̻��̸� D����, �� �ܿ��� F������ ���

        int score = 59;
        char grade = 'A';

        if (score >= 90)//[1] 90�� �̻��̸�
        {
            grade = 'A';
        }
        else if (score >= 80)//[2] 80�� �̻��̸�
        {
            grade = 'B';
        }
        else if (score >= 70)//[3] 70�� �̻��̸�
        {
            grade = 'C';
        }
        else if (score >= 60)//[4] 60�� �̻��̸�
        {
            grade = 'D';
        }
        else
        {
            grade = 'F';
        }
       
        Debug.Log($"������ {grade}���� �Դϴ�");
    }
}

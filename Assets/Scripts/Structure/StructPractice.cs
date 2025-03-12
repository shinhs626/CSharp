using UnityEngine;

//��ø ����ü: ����ü�ȿ� ����ü
//������ �����ϴ� ����ü �����
//�� ������ ������ �����ϴ� ����ü
struct Score
{
    public int kor;     //���� ����
    public int eng;     //���� ����
}

//�л� ������ �����ϴ� ����ü ���� - ���� ����
struct Student
{
    public int number;      //�л� ��ȣ
    public string name;     //�л� �̸�
    public Score scores;    //���� ���� - Score ����ü : ��ø ����ü
}

public class StructPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ����ü ���� ���� �� ��Ҽ� ����
        Student[] students = new Student[3];

        students[0].number = 1;
        students[0].name = "�̼���";
        students[0].scores.kor = 70;
        students[0].scores.eng = 10;

        students[1].number = 2;
        students[1].name = "�������";
        students[1].scores.kor = 100;
        students[1].scores.eng = 100;

        students[2].number = 3;
        students[2].name = "ȫ�浿";
        students[2].scores.kor = 50;
        students[2].scores.eng = 50;

        //[3] �л� ����ü ��� - ����ǥ ���
        for (int i = 0; i < students.Length; i++)
        {
            Debug.Log($"{students[i].number}-{students[i].name}-���� ���� : {students[i].scores.kor}-���� ���� : {students[i].scores.eng}");
        }
    }
}

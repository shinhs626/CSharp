using UnityEngine;

//������ : ������ �Ʒ��� ������� ��ɹ��� �����ϴ� ���� 
public class SequenceDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ���� ���� - �ʱ�ȭ
        int kor = 100;      //��������
        int eng = 90;       //��������

        int total = 0;      //����
        double avg = 0.0;   //���

        //[2] ������ �� ����(�Ҵ�)
        total = kor + eng;  //���� ���
        avg = total / 2.0;  //��� ���

        //[3] ������ ����Ͽ� ��� ���
        Debug.Log($"���� : {total}"); //190
        Debug.Log($"��� : {avg}"); //95
    }
}
/*
<���> : ���α׷��� �帧(����)�� �����ϴ� ����
- ������ : ������ �Ʒ��� ������� ��ɹ��� �����ϴ� ���� 
- ���ǹ�(if - else, switch) : ���ǿ� ���� ���� �ٸ� ��ɹ��� �����ϴ� ����
- �ݺ��� :
*/
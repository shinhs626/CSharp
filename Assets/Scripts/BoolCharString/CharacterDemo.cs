using UnityEngine;

//���� �̿��� ������ ���� : bool, char, string
//char(������) :���� ������ ����
public class CharacterDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] char �� ���� ���� �� �ʱ�ȭ
        char grade = 'A';
        char kor = '��';
        char ea = '��';

        //[2] ����ϱ�
        Debug.Log("grade :" + grade);
        Debug.Log("�츮���� :" + kor+ea);

    }
}

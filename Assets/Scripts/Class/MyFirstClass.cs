using UnityEngine;

//���� �޼��� ȣ��, �ν��Ͻ� �޼��� ȣ��
public class MyFirstClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ����(static) �޼��� ȣ��
        //ȣ�� ��� : Ŭ�����̸�.�޼����̸�()
        ClassMember.StaticMethod();

        //[2] �ν��Ͻ�(Instance) �޼��� ȣ��
        //ȣ�� ��� : new Ű���带 ����ؼ� ��ü(Instance, ��ü)�� ���� ���� -> Ŭ�����̸� ��ü�̸� = new Ŭ�����̸�() -> ���� : ��ü.�޼����̸�()
        ClassMember instance = new ClassMember();
        instance.Instance();
    }
}

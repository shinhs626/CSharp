using UnityEngine;

//��ø if��
public class IfNested : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string name = "ȫ�浿";
        int age = 20;
        
        //�̸��� ȫ�浿�� ������ ���๮(��ɹ�)�� ����
        if(name == "ȫ�浿")
        {
            if(age == 20)
            {
                //�̸��� ȫ�浿�̰� ���̰� 20���̸� ���๮(��ɹ�)�� ����
                Debug.Log($"�̸���{name}, ���̴�{age}�Դϴ�");
            }
        }
        /*
        if(name == "ȫ�浿" && age == 20)
        {
            Debug.Log($"�̸���{name}, ���̴�{age}�Դϴ�");
        }
        */
    }
}

using UnityEngine;

//[1]�������� �����ϴ� ������ ����(����, �����)

enum Animal
{
    Mouse,
    Cow,
    Tiger,
}

public class EnumAnimal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] ������ ���� �����ϰ� �ʱ�ȭ
        Animal animal = Animal.Tiger;
        Debug.Log(animal);

        //[3] ��� - ���ǹ����� ���ǽ�
        if(animal == Animal.Tiger)
        {
            Debug.Log("ȣ����");
        }
    }
}

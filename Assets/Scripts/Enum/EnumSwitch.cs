using UnityEngine;

//�������� switch���� �Բ� ���� ���Ǿ�����
//�������� �̿��Ͽ� �ѱ� ���� �̸� ����ϱ�
enum Animalw
{
    Chicken,
    Rino,
    Lyon
}
public class EnumSwitch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //������ ���� ����, �ʱ�ȭ
        Animalw ani = Animalw.Rino;
        PrintAnimal(ani);
    }

    //�Ű� ������ ������ ������ �޾� �ѱ� �̸� ����ϱ�
    void PrintAnimal(Animalw animal)
    {
        switch (animal)
        {
            case Animalw.Chicken:
                Debug.Log("��");
                break;
            case Animalw.Rino:
                Debug.Log("�ڻԼ�");
                break;
            case Animalw.Lyon:
                Debug.Log("����");
                break;
        }
    }
}

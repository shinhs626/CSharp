using UnityEngine;

//[1]����ü ����, ���� : �ΰ��� ������ �����ϴ� ����ü �����
/*struct Point
{
    public int x; //public Ű���带 �����Ͽ� �ܺο��� int x ������ ��� �����ϵ��� ����
    public string y;
}*/

public class StructDescription : MonoBehaviour
{
    struct Point
    {
        public int x; //public Ű���带 �����Ͽ� �ܺο��� int x ������ ��� �����ϵ��� ����
        public string y;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2]����ü ������ ���� ����
        Point point;

        //[3]x,y������ ���� ����(����,�Ҵ�), �ʱ�ȭ
        point.x = 100;
        point.y = "200";

        //[4]���
        Debug.Log($"x: {point.x}, y:{point.x}");
    }
}

/*
Variable(����) : �����͸� �����ϴ� �׸�
Array(�迭) : �ϳ��� �̸����� ���� ������ �����͸� ���� �� ��� �׸�, ����, ������ Ȯ��
Struct(����ü) : �ϳ��� �̸����� ���� �ٸ� �����͵�, �Ǵ� �Լ����� ��� �����ϴ� �׸� (������ ����), ������ Ȯ��
: ����� ���� ������ ����

//����ü ����
struct (����ü �̸�)
{
    //���� �ٸ� ������ �����͵�
    //�Լ���
}
*/
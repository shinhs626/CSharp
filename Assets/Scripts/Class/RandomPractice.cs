using UnityEngine;

//�ζ� ��ȣ ������
public class RandomPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RandomNumber();
    }
    
    void RandomNumber()
    {
        System.Random random = new System.Random();

        int[] numbers = new int[6]; //numbers��� 6���� ��Ҽ��� ���� �迭 ����

        int number = 0;
        bool flag = false;//�ߺ� �˻��ؼ� �ߺ��̸� true, �ƴϸ� false

        for (int i = 0; i < 6; i++)
        {
            number = random.Next(1, 46);// 1���� 45���� ������ ������ ���ϱ�

            //�ߺ� üũ - number�� ���� ���� �ζǹ�ȣ�� ���ؼ� �˻�
            //�̰� ������ �� �� true�� �ȴٸ� false�� �ٲ��� �ʾ� ��� true�� ���·� �����
            flag = false;

            if(i > 0)
            {
                for(int j = 0; j < i; j++)
                {
                    if (numbers[j] == number)
                    {
                        flag = true;
                    }
                }
            }
            //
            if (flag == false)  //�ߺ��� �ƴϸ�
            {
                numbers[i] = number;
            }
            else    //�ߺ��̸� �ٽ� ����ϱ� ���� �ε����� �����Ѵ�
            {
                i--;
            }
        }
        //�ζǹ�ȣ ���
        for(int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
        }
        




        //�Ʒ� �ڵ�� ���� �ڵ� �̸� �ʹ� �ڵ尡 ������
        /*int number1 = random.Next(1, 46);
        int number2 = random.Next(1, 46);
        int number3 = random.Next(1, 46);
        int number4 = random.Next(1, 46);
        int number5 = random.Next(1, 46);
        int number6 = random.Next(1, 46);
        for(int i = 0; i < 6; i++)
        {
            if (number1 == number2 && number1 == number3 && number1 == number4 && number1 == number5 && number1 == number6)
            {
                number1 = random.Next(1, 46);
            }
            if (number2 == number1 && number2 == number3 && number2 == number4 && number2 == number5 && number2 == number6)
            {
                number2 = random.Next(1, 46);
            }
            if (number3 == number2 && number3 == number1 && number3 == number4 && number3 == number5 && number3 == number6)
            {
                number3 = random.Next(1, 46);
            }
            if (number4 == number2 && number4 == number3 && number4 == number1 && number4 == number5 && number4 == number6)
            {
                number4 = random.Next(1, 46);
            }
            if (number5 == number2 && number5 == number3 && number5 == number4 && number5 == number1 && number5 == number6)
            {
                number5 = random.Next(1, 46);
            }
            if (number6 == number2 && number6 == number3 && number6 == number4 && number6 == number5 && number6 == number1)
            {
                number6 = random.Next(1, 46);
            }
        }
        

        Debug.Log($"{number1}-{number2}-{number3}-{number4}-{number5}-{number6}");*/

    }
}
/*
[Q]
�ζ� ��ȣ ������ �����
[1] 6�� ��ȣ
[2] 1~45�� ���� ��ȣ
[3] �ߺ��� ���ڰ� ������ �ȵȴ�
*/
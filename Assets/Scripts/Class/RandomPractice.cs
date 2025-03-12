using UnityEngine;

//로또 번호 생성기
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

        int[] numbers = new int[6]; //numbers라는 6개의 요소수를 가진 배열 선언

        int number = 0;
        bool flag = false;//중복 검사해서 중복이면 true, 아니면 false

        for (int i = 0; i < 6; i++)
        {
            number = random.Next(1, 46);// 1부터 45까지 랜덤한 정수값 구하기

            //중복 체크 - number와 먼저 뽑힌 로또번호와 비교해서 검사
            //이게 없으면 한 번 true가 된다면 false로 바뀌지 않아 계속 true인 상태로 진행됨
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
            if (flag == false)  //중복이 아니면
            {
                numbers[i] = number;
            }
            else    //중복이면 다시 계산하기 위해 인덱스를 조정한다
            {
                i--;
            }
        }
        //로또번호 출력
        for(int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
        }
        




        //아래 코드는 오류 코드 이며 너무 코드가 더러움
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
로또 번호 생성기 만들기
[1] 6개 번호
[2] 1~45번 랜덤 번호
[3] 중복된 숫자가 있으면 안된다
*/
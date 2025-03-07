using UnityEngine;

//break로 무한루프 빠져 나오기
public class BreakInfiniteLoop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //for문 무한루프
        /*for(; ; )
        {

        }*/

        //while문 무한루프 : 증감식 없애기
        /*while (조건식)
        {
            반복 실행문
        }*/

        //doWhile문 무한루프 : 증감식 없애기
        /*do
        {
            반복 실행문
        }while(조건식);*/

        int number = 0;

        while (true)
        {
            Debug.Log($"{number}");
            number++;
            if(number >= 5)
            {
                break;
            }
        }
    }
}

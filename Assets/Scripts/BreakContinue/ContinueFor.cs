using UnityEngine;

//Continue문은 반복문에서 Continue문을 만나면 Continue문 아래에 있는 실행문을 실행하지 않고
//다음 반복문의 조건식을 판별한 다음 반복문을 실행합니다
public class ContinueFor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1부터 5까지 홀수만 출력하는 프로그램
        /*for(int i = 0; i < 5; i++)
        {
            if(i % 2 != 0)
            {
                Debug.Log($"{i + 1}");
            }
        }*/
        for(int i = 0; i < 5; i++)
        {
            if(i % 2 == 0) //짝수 판별식
            {
                continue; //현재 반복 실행중인 반복문을 중지하고 다음 반복문으로 이동하라
            }
            Debug.Log($"{i+1}");
        }
    }
}

using UnityEngine;

//abs(절대값)을 구하는 함수 만들기
public class FunctionAbs : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number = -21;
        //int abs = Abs(number);
        int abs = Mathf.Abs(number); //절대값을 구하는 내장함수

        Debug.Log($"{number}의 절대값은{abs}입니다");
    }

    //매개변수로 들어온 정수의 절대값을 반환하는 함수
    int Abs(int num)
    {
        /*if(num < 0)
        {
            return -num;
        }
        else
        {
            return num;
        }*/

        return (num < 0) ? -num : num;
    }
}

using UnityEngine;

//Parameter(매개변수)
public class FunctionParameter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2]매개 변수가 있는 함수 호출(사용)하기
        ShowMessage("안녕하세요");

        ShowMessage("안녕");
    }
    
    //[1]매개변수가 있는 함수 선언(정의하기)
    //매개변수로 입력받은 문자열을 출력
    void ShowMessage(string message)
    {
        Debug.Log(message);
    }
}

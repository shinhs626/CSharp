using UnityEngine;

//PostfixOperator(후위연산자(num++,--)) : 같은 라인에서 연산하는 순위가 가장 낮음(가장 나중에 연산)
public class PostfixOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;

        int y = x++;

        Debug.Log("x: " + x); // 4

        Debug.Log("y: " + y); // 연산한 뒤에 값이 증가되므로 콘솔에는 3이 출력됨
    }
}

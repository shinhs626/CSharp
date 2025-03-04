using UnityEngine;

public class SwapDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 100;
        int j = 200;
        int temp = i;//temp에 i값을 저장

        Debug.Log($"처음 i:{i}, j:{j}");

        i = j;//i에 j값을 저장
        j = temp;// j에 저장해두었던 temp값을 저장
        Debug.Log($"변경 i:{i}, j:{j}");

    }
}

/*
 [Q]
+,-,*,/ 연산자를 사용하지 않고 변수 i,와 j의 값을 서로 바꾸는 코드를 작성하시오.
=만 사용하여 작성하시오.
  [output]
처음 i:100, j:200
변경 i:200, j:100
 */

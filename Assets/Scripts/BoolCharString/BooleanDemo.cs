using UnityEngine;

//bool(불) : 불형, 논리자료형, 참(true) or 거짓(false) 값만 저장한다
public class BooleanDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] bool 변수 선언하고 초기화
        bool bln = true;
        Debug.Log("bln: "+bln);
        Debug.Log($"bln:{bln}");

        bool isOut = false;
        Debug.Log("isOut: " + isOut);
        Debug.Log($"isOut:{isOut}");
    }
}

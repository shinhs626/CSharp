using UnityEngine;

//string == System.String
//문자열 길이 구하기
public class StringClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string s1 = "안녕하세요";
        System.String s2 = "반갑습니다.";

        Debug.Log($"{s1}길이 - {s1}, {s2}의 길이 {s2.Length}");
    }
}

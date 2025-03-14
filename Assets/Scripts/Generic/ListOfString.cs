using System.Collections.Generic;
using UnityEngine;

//리스트 제네릭 클래스 : List<T> => List<int>, List<T> => List<string>, ... ,List<object>
public class ListOfString : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] string 전용 리스트에 인스턴스(객체,개체)생성
        List<string> strList = new List<string>();

        //[2] 리스트에 데이터 넣기
        strList.Add("빨강");
        strList.Add("초록");
        strList.Add("파랑");

        //[3] 리스트에서 데이터 꺼내기
        foreach(var str in strList)
        {
            Debug.Log(str);
        }

        for (int i = 0; i < strList.Count; i++)
        {
            Debug.Log(strList[i]);
        }
    }
}

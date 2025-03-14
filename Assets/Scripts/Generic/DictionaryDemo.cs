using System.Collections.Generic;
using UnityEngine;

public class DictionaryDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] Dictionary 클래스의 인스턴스 생성 : Dictionary 인터페이스 받기 
        IDictionary<string, string> data = new Dictionary<string, string>();

        //[2] Dictionary 데이터 넣기
        data.Add("시", "서울특별시");
        data.Add("구", "강동구");

        //[3] 데이터 삭제
        data.Remove("시");

        //[4] Dictionary 데이터 넣기 - 인덱서를 사용해서 입력
        data["동"] = "천호동";

        //[5] 키 값은 중복이 불가능하고 같은 키값으로 추가가 안된다
        try
        {
            data["구"] = "강남구";
            //data.Add("구", "강남구");
        }
        catch(System.Exception ex)
        {
            Debug.Log(ex.Message);
        }

        //[6] 사용
        foreach (KeyValuePair<string, string> i in data)
        {
            Debug.Log(i);
        }

        //[7] 인덱서 사용
        Debug.Log(data["구"]);
    }
}

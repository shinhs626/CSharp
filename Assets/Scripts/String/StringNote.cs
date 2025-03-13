using UnityEngine;

public class StringNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //string 변수 선언하고 빈 값으로 초기화
        string str = "";
        str = System.String.Empty;  //빈 값으로 저장(null 아님)
        str = " Abc Def Fed Cba ";  //앞 뒤에 공백 하나 씩 주어서 값 저장
        
        Debug.Log(str);
        Debug.Log(str.Length);  //문자열 길이 구하기
        Debug.Log(str[5]);      //문자 D 출력하기
        Debug.Log(str.ToUpper()); //문자 대문자로 출력하기
        Debug.Log(str.ToLower()); //문자 소문자로 출력하기

        //공백 제거 기능
        Debug.Log(str.Trim());  //공백 앞,뒤 제거 메서드
        Debug.Log(str.TrimStart()); //문자열 앞에 공백 제거 메서드
        Debug.Log(str.TrimEnd());   //문자열 뒤에 공백 제거 메서드

        //검색
        Debug.Log(str.IndexOf('e'));    //'e'가 위치한 인덱스 가져오기
        Debug.Log(str.Substring(5,3)); //5번 인덱스 부터 3글자 가져오기
        Debug.Log(str.Substring(5)); //5번 인덱스부터 끝까지 가져오기
        Debug.Log(str.Remove(5,3)); //5번 인덱스부터 3글자 삭제
        Debug.Log(str.Remove(5));   //5번 인덱스부터 끝까지 삭제

        //비교
        Debug.Log(str[1] == str[15]);   //false
        Debug.Log("ABC".Equals("Abc")); //false
        Debug.Log(System.String.Compare("BAC", "Bac")); // 0(같음), 1(다름 >), -1(다름 < ) 

        //연결
        var hi1 = "안녕";
        var hi2 = "하세요";

        Debug.Log(hi1 + hi2);
        Debug.Log($"{hi1}{hi2}");
        Debug.Log(System.String.Format("{0}{1}",hi1,hi2));

        //format
        Debug.Log(System.String.Format("{0:C}", 1000));  //C : 통화량
        Debug.Log(System.String.Format("{0:#,###}", 1000000));  //세 자리 콤마

        //분리하기 - 문자열 전체 공백 제거
        string[] strArray = str.Trim().Split(' ');
        string strAll = "";
        foreach (var s in strArray)
        {
            //Debug.Log(s);
            strAll = strAll + s;
        }
        Debug.Log(strAll);
    }
}

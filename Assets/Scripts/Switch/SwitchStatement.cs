using UnityEngine;

public class SwitchStatement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("오늘 날씨는 어떤가요?(읽을 내용: 맑음, 흐림, 비, 눈)");
        
        string weather = "흐림";

        switch (weather)
        {
            case "맑음":
                Debug.Log("맑은 날씨입니다.");
                break;
            case "흐림":
                Debug.Log("흐린 날씨입니다.");
                break;
            case "비":
                Debug.Log("비가 내리고 있습니다.");
                break;
            case "눈":
                Debug.Log("눈이 내리고 있습니다.");
                break;
            default:
                Debug.Log("잘못된 날씨를 입력했습니다.");
                break;
        }
    }
}

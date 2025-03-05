using UnityEngine;

//중첩 if문
public class IfNested : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string name = "홍길동";
        int age = 20;
        
        //이름이 홍길동과 같으면 실행문(명령문)을 실행
        if(name == "홍길동")
        {
            if(age == 20)
            {
                //이름이 홍길동이고 나이가 20살이면 실행문(명령문)을 실행
                Debug.Log($"이름은{name}, 나이는{age}입니다");
            }
        }
        /*
        if(name == "홍길동" && age == 20)
        {
            Debug.Log($"이름은{name}, 나이는{age}입니다");
        }
        */
    }
}

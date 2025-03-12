using UnityEngine;

//열거형은 switch문과 함께 많이 사용되어진다
//열거형을 이용하여 한글 동물 이름 출력하기
enum Animalw
{
    Chicken,
    Rino,
    Lyon
}
public class EnumSwitch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //열거형 변수 선언, 초기화
        Animalw ani = Animalw.Rino;
        PrintAnimal(ani);
    }

    //매개 변수로 열거형 변수를 받아 한글 이름 출력하기
    void PrintAnimal(Animalw animal)
    {
        switch (animal)
        {
            case Animalw.Chicken:
                Debug.Log("닭");
                break;
            case Animalw.Rino:
                Debug.Log("코뿔소");
                break;
            case Animalw.Lyon:
                Debug.Log("사자");
                break;
        }
    }
}

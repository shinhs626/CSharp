using UnityEngine;

namespace Property
{
    public class PropertyDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1] public 메서드 Get, Set 이용 - 빨간 자동차
            Car carOne = new Car();
            carOne.SetColor("Red");
            Debug.Log(carOne.GetColor());

            //[2] public 속성 이용 - 하얀색 자동차
            Car carTwo = new Car();
            carTwo.SetColor("White");
            Debug.Log(carTwo.GetColor());

            //[3] 읽기 전용 속성
            Car carThree = new Car();
            //carThree.Maker = "KIA";
            Debug.Log(carThree.Maker);

            //[4] 자동속성, 축약형
            Car myCar = new Car();
            myCar.Name = "밤밤";
            Debug.Log(myCar.Name);
        }
    }

}

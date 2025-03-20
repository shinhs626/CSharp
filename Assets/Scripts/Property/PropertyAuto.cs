using UnityEngine;

namespace Property
{
    public class PropertyAuto : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Truck 인스턴스 생성
            Truck h = new Truck();
            h.Name = "현대";
            Debug.Log(h.Name);

            Truck kia = new Truck();
            kia.Name = "기아";
            kia.Color = "White";
            Debug.Log($"차:{kia.Name} 컬러:{kia.Color}");
        }
    }
}


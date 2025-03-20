using System.Collections;
using UnityEngine;

namespace Indexer
{
    public class IndexerNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Car클래스의 인스턴스 생성
            Car car = new Car(3);
            car[0] = "현대자동차";
            car[1] = "KIA";
            car[2] = "쉐보레";

            //인덱서 사용
            /*for (int i = 0; i < 3; i++)
            {
                Debug.Log(car[i]);
            }*/
            foreach(var c in car)
            {
                Debug.Log(c);
            }
        }
    }

}

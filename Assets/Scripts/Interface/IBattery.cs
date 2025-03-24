using UnityEngine;

namespace Interface
{
    //[1] Interface
    public interface IBattery
    {
        string GetName();   //메서드 선언하고 구현부 생략, 인터페이스에서는 public이 기본0
    }

    public class Good : IBattery
    {
        public string GetName()
        {
            return "Good";
        }
    }
    
    public class Bad : IBattery
    {
        public string GetName()
        {
            return "Bad";
        }
    }
    public class HdCar
    {
        //필드
        private IBattery battery;
        public HdCar(IBattery battery)
        {
            this.battery = battery;
        }
        public void Run()
        {
            Debug.Log($"{battery.GetName()}");
        }
    }

}

using UnityEngine;

namespace Constructor
{
    public class WithService
    {
        //읽기전용 필드
        private readonly string serviceName = "";

        //생성자 - 생성자에서는 읽기 전용 필드 초기화 가능
        public WithService()
        {
            serviceName = "파일";
        }

        public WithService(string name)
        {
            this.serviceName = name;
        }

        public void Run()
        {
            //serviceName = "file";
            Debug.Log(this.serviceName);
        }
    }

}


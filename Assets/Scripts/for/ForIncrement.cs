using UnityEngine;

public class ForIncrement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //������
        //���ڸ� 0���� 10���� 2�� �����ϸ鼭 ���
        for(int i = 0; i < 11; i += 2)
        {
            Debug.Log($"Count:{i}");
        }

    }
}

using UnityEngine;

public class SwapDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 100;
        int j = 200;
        int temp = i;//temp�� i���� ����

        Debug.Log($"ó�� i:{i}, j:{j}");

        i = j;//i�� j���� ����
        j = temp;// j�� �����صξ��� temp���� ����
        Debug.Log($"���� i:{i}, j:{j}");

    }
}

/*
 [Q]
+,-,*,/ �����ڸ� ������� �ʰ� ���� i,�� j�� ���� ���� �ٲٴ� �ڵ带 �ۼ��Ͻÿ�.
=�� ����Ͽ� �ۼ��Ͻÿ�.
  [output]
ó�� i:100, j:200
���� i:200, j:100
 */

using UnityEngine;

public class SignedInteger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] SignedInteger
        sbyte iSbyte = 127;                     //8 bit ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ
        short iInt16 = 32767 ;                  //16 bit ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ
        int iInt32 = 2147483647;                //32 bit ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ
        long iInt64 = 9223372036845775807;      //64 bit ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ

        //[2] UnSignedInteger
        byte iByte = 255;                       //8 bit ��ȣ�� ���� ������ ���� ���� �� �ʱ�ȭ
        ushort iUInt16 = 65535;                 //16bit ��ȣ�� ���� ������ ���� ���� �� �ʱ�ȭ
        uint iUInt32 = 4294967295;              //32bit ��ȣ�� ���� ������ ���� ���� �� �ʱ�ȭ

        //** �������� ulong �±׸� ����Ҷ� UL�� ������ ������ ������ ���� ������ �������� �׷��� ulong UL�� ���̴°� �������� **
        ulong iUInt64 = 18446744073709551615UL; //64bit ��ȣ�� ���� ������ ���� ���� �� �ʱ�ȭ
        //

        Debug.Log(iSbyte + "," + iInt16 + "," + iInt32 + "," + iInt64);
        Debug.Log(iByte + "," + iUInt16 + "," + iUInt32 + "," + iUInt64);

    }
}

/*
1 Bit (0,1)
1 Byte : 8 bit

0000 0000 = 0
0000 0001 = 1
0000 0010 = 2
0000 0100 = 4
0000 1000 = 8


8bit
(+,-)
sbyte : -128 ~ 127

(+)
byte :0 ~ 255
*/

/*
SignedInteger (+,-) ��ȣ�� �ִ� ������ ������ ����(type)

UnSignedInteger (+,-) ��ȣ�� ���� ������ ������ ����(type)
*/
using UnityEngine;

public class SignedInteger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] SignedInteger
        sbyte iSbyte = 127;                     //8 bit 부호가 있는 정수형 변수 선언 및 초기화
        short iInt16 = 32767 ;                  //16 bit 부호가 있는 정수형 변수 선언 및 초기화
        int iInt32 = 2147483647;                //32 bit 부호가 있는 정수형 변수 선언 및 초기화
        long iInt64 = 9223372036845775807;      //64 bit 부호가 있는 정수형 변수 선언 및 초기화

        //[2] UnSignedInteger
        byte iByte = 255;                       //8 bit 부호가 없는 정수형 변수 선언 및 초기화
        ushort iUInt16 = 65535;                 //16bit 부호가 없는 정수형 변수 선언 및 초기화
        uint iUInt32 = 4294967295;              //32bit 부호가 없는 정수형 변수 선언 및 초기화

        //** 예전에는 ulong 태그를 사용할때 UL을 붙이지 않으면 오류가 났음 지금은 괜찮은데 그래서 ulong UL을 붙이는게 안정적임 **
        ulong iUInt64 = 18446744073709551615UL; //64bit 부호가 없는 정수형 변수 선언 및 초기화
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
SignedInteger (+,-) 부호가 있는 정수형 데이터 형식(type)

UnSignedInteger (+,-) 부호가 없는 정수형 데이터 형식(type)
*/
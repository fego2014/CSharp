using UnityEngine;



public class SignedInteger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        //SignedInteger
        sbyte iSbyte = 127; //8��Ʈ(1����Ʈ) ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ
        short iInt16 = 32767; //16��Ʈ ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ
        int iInt32 = 2147483647; //32��Ʈ ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ
        long iInt64 = 9223372036845775807; //64��Ʈ ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ

        Debug.Log("sbyte:" + iSbyte);
        Debug.Log("short:" + iInt16);
        Debug.Log("int:" + iInt32);
        Debug.Log("long:" + iInt64);

        //UnSignedInteger
        byte iByte = 255; //8��Ʈ(1����Ʈ) ��ȣ�� ���� ������ ���� ���� �� �ʱ�ȭ
        ushort iUint16 = 65535; //16��Ʈ ��ȣ�� ���� ������ ���� ���� �� �ʱ�ȭ
        uint iUint32 = 4294967295; //32��Ʈ ��ȣ�� ���� ������ ���� ���� �� �ʱ�ȭ
        ulong iUint64 = 18446744073709551615; //64��Ʈ ��ȣ�� ���� ������ ���� ���� �� �ʱ�ȭ

        Debug.Log("byte:" + iByte);
        Debug.Log("ushort:" + iUint16);
        Debug.Log("uint:" + iUint32);
        Debug.Log("ulong:" + iUint64);
    }

}
/*
1 bit 0, 1 (2����)
1 Byte : 8 bit (2����)
0000 0000 -> 0
0000 0001 -> 1
0000 0010 -> 2
0000 0011 -> 3
0000 0100 -> 4
(��256���� 0~255)

    2����= 0,1
    16����= 0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,

8bit
    sbyte: -128 ~ 0 ~ 127 (+,-,0)
    byte:0~255 (+,0)
 */

/*
SignedInteger (+,-) ��ȣ�� �ִ� ������ ������(Ÿ��)
    

UnSignedInteger (+,-) ��ȣ�� ���� ������ ������, -�� ���� ������,(Ÿ��)
 */
using UnityEngine;


//TypeConversion (형식변환)
public class IntToByte : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //int형 변수 x를 선언하고 255로 초기화
        int x = 255;

        //byte 형 변수 y를 선언하고 x의 값으로 초기화
        //byte y = x;
        //byte 저장범위: 0~255

        byte y = (byte)x; //명시적 형변환을 사용하여 int형 변수의 값을 byte형 변수에 저장한다.

        Debug.Log(x + "->" + y); //콘솔창에 출력하라

    }

}

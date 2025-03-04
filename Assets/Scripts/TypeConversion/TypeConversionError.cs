using UnityEngine;


//TypeConversion (형식변환)
public class TypeConversionError : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]long형 변수 ㅣ을 선언하고 long형 변수가 가질수 있는 가장 큰값을 저장한다
        long l=long.MaxValue;

        Debug.Log("l의 값:"+l); //콘솔창에 출력하라

        //[2]int형 변수 i를 선언하고 long형 변수 l의 값을 int형으로 변환하여 저장한다
        //int i = l; //에러가 발생한다. long형 변수의 값을 int형 변수에 저장할 수 없다. type conversion error.
        int i = (int)l; //명시적 형변환을 사용하여 long형 변수의 값을 int형 변수에 저장한다.

        Debug.Log("i의 값:" + i); 


    }

}

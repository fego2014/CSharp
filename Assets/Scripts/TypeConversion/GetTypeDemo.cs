using UnityEngine;

//GetType: 변수의 타입 읽어오기
public class GetTypeDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 1234;           //정수형
        double d = 3.14;        //실수형
        string s = "안녕하세요"; //문자열   
        char c = 'A';           //문자

        Debug.Log(i.GetType()); //System.Int32
        Debug.Log(d.GetType()); //System.Double
        Debug.Log(s.GetType()); //System.String
        Debug.Log(c.GetType()); //System.Char
    }

}

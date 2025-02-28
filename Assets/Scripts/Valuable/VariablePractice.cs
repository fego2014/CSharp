using UnityEngine;

public class VariablePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   /*
        int first = 10;
        int second = 20;
        int third = 30;

        Debug.Log(first+","+second+","+third);
        */

        //[1]변수 선언
        int first, second, third;

        //[2]변수에 값 저장
        first = 10;
        second = 20;
        third = 30;

        //[3]변수사용
        Debug.Log(first + "," + second + "," + third);
    }

}

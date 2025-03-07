using UnityEngine;

public class WhileCountdown : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]1부터 5까지 1씩 증가
        //초기식
        int i = 1;

        while(i<=5) //조건식
        {
            //반복실행문
            Debug.Log($"카운트다운:{i}");

            //증감식
            i++;
        }

        Debug.Log("=============================================");


        //[2]5부터 1까지 1씩 감소
        //초기식
        int n = 5;

        while (n > 0)
        {
            Debug.Log($"카운트다운:{n}");

            n--;
        }
    }

}

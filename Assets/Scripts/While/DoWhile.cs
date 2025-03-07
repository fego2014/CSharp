using UnityEngine;

//안녕하세요 3번 출력하는 프로그램
public class DoWhile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]초기식
        int i = 4;

        do
        {
            //반복실행문
            Debug.Log("안녕하세요");
            //[2]증감식
            i++;
        }
        while (i < 3); //[3]조건식

    }

}

/*
dowhile 문 - 반복문
먼저 반복 실행문을 1번 실행한다
조건식이 true이면 반복문을 실행한다
조건식이 fase이면 while문을 종료한다

do
{
    //반복 실행문
} while (조건식)

 */
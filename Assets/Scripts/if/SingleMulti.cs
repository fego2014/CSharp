using UnityEngine;

public class SingleMulti : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //만약 조건식이 참이면 {} 안에 있는 실행문을 실행하라
        /*
        if(조건식)
        {
            //실행문1
            //실행문2
            //...
        }
        */

        //단문은 {} 실행문이 1개
        if (1 == 1)
        {
            Debug.Log("단문1");
        }
        if (1 == 1) // {}(코드블록) 생략이 되면 바로 아래있는 1줄만 실행
            Debug.Log("단문2");

        if (1 == 1) Debug.Log("단문3"); // {} 생략이 되면 바로 아래있는 1줄만 실행

        //복문 (실행문이 2개 이상일때)
        if (1 == 1)
        {
            Debug.Log("복문1");
            Debug.Log("복문2");
        }
    }

}
/*
if()
{

}
 */
using Unity.Mathematics;
using UnityEngine;

public class FunctionMaxMin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int result = Max(3, 5);
        Debug.Log(result);

    }

    
    int Max(int x, int y)
    {
        /*
        if (x < y)
        {
            return y;
        }
        else
        {
            return x;
        }
        */

        /*
        int max = (x > y) ? x : y;
        return max;
        */

        return (x > y) ? x : y;
    }


    //[2]매개변수로 입력 받은 두개의 정수중 작은 수를 반환하는 함수
    int Getmin(int x, int y)
    {
        if (x < y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }
}

/*
 
[Q]
1. 매개변수로 입력받은 두개의 정수중 큰수를 반환하는 함수
2. 매개변수를 입력받은 두개의 정수중 작은수를 반환하는 함수
3. 3,5를 입력받아 큰 수를 출력하기
4. -3,-5를 입력받아 작은 수를 출력하기

[output]
3과 5중 큰 수는 (반환값)이다
-3과 -5중 작은 수는 (반환값)이다

 */
using UnityEngine;

public class ElseIF : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //number1, number2 값을 입력받아서
        //[1] number1이 크면 number1이 큽니다 출력
        //[2] number2가 크면 number2가 큽니다 출력
        //[3] number1과 number2가 같으면 두 수는 같습니다 출력

        //선언문
        int number1 = 10;
        int number2 = 10;

        if (number1 >= number2) //조건식1
        {
            //실행문1
            Debug.Log("number1이 큽니다");
        }
        else if (number1 <= number2) //조건식2
        {
            //실행문2
            Debug.Log("number2가 큽니다");
        }
        else if (number1==number2) //조건식3
        {
            //실행문3
            Debug.Log("두수의 크기는 같습니다");
        }

        //실행문4
    }

}

/*
elseif 문
[1] 조건식1 참이면
선언문 -> 실행문1 -> 실행문4
[2] 조건식1 거짓이고 조건식2 참이면
선언문 -> 실행문2 -> 실행문4
[3] 조건식1,2 거짓이고 조건식3 참이면
선언문 -> 실행문3 -> 실행문4
[4] 조건식1이 참이고 조건식2도 참이면
선언문 -> 실행문1 -> 실행문4

 */
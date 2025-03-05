using UnityEngine;

public class IfElsePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 85;

        if (score >= 90)
        {
            Debug.Log("금메달");
        }
        else if (score >= 80)
        {
            Debug.Log("은메달");
        }
        else if (score >= 70)
        {
            Debug.Log("동메달");
        }
        else if (score <= 60)
        { 
            Debug.Log("노메달"); 
        }
    }

}

/*
[Q]
score가 90이상이면 금메달 출력, 80이상이면 은메달 출력,
70이상이면 동메달 출력, 그외 나머지는 노메달 출력
score는 85점이라고 가정합니다.

[output]
()메달을 수상하셨습니다.
 */
using UnityEngine;

//
public class Else: MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 61;                //[1]

        //만약 score가 60보다 크면
        if (score > 60)                //[2]
        {
            //출력
            Debug.Log("합격입니다.");
        }
        else //조건식이 아니면
        {
            //출력
            Debug.Log("불합격입니다."); //[3]
        }

        Debug.Log("프로그램 종료");     //[4]
    }


    // score
}

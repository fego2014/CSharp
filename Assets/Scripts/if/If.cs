using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

//만약 score가 60점 이상이면 "합격"을 출력하라,
//score 61점으로 초기화
public class If : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 61; //점수 초기화
        if (score >= 60) //만약 score가 60점 이상이면
        {
            //실행문
            Debug.Log("합격"); //합격 출력
        }
    }

}

/*
if문 - 조건문
조건식이 참일 때만 실행되는 명령문
조건식이 거짓이면 실행문을 실행하지 않습니다

//만약 조건식이 참이면 {} 안에 있는 실행문을 실행하라   
if(bool)
{
    //실행문1
    //실행문2
    //...
}
 */

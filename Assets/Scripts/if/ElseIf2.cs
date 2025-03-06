using UnityEngine;

public class ElseIf2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //score가 90점 이상이면 A, 80점 이상이면 B, 70점 이상이면 C,
        //60점 이상이면 D, 나머지 F

        //[0]선언문
        int score = 59;
        char grade = 'A';

        if (score >=90) //[1]score가 90점 이상이면 A
        {
            grade = 'A';
        }
        else if (score >=80) //[2]score가 80점 이상이면 B
        {
            grade = 'B';
        }
        else if (score >=70) //[3]score가 70점 이상이면 C
        {
            grade = 'C';
        }
        else if (score >= 60) //[4]score가 60점 이상이면 D
        {
            grade = 'D';
        }
        else                 //[5]나머지 F
        {
            grade = 'F';
        }
        Debug.Log($"{grade} 학점");
    }

}

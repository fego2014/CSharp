using UnityEngine;

public class ElseIf2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //score�� 90�� �̻��̸� A, 80�� �̻��̸� B, 70�� �̻��̸� C,
        //60�� �̻��̸� D, ������ F

        //[0]����
        int score = 59;
        char grade = 'A';

        if (score >=90) //[1]score�� 90�� �̻��̸� A
        {
            grade = 'A';
        }
        else if (score >=80) //[2]score�� 80�� �̻��̸� B
        {
            grade = 'B';
        }
        else if (score >=70) //[3]score�� 70�� �̻��̸� C
        {
            grade = 'C';
        }
        else if (score >= 60) //[4]score�� 60�� �̻��̸� D
        {
            grade = 'D';
        }
        else                 //[5]������ F
        {
            grade = 'F';
        }
        Debug.Log($"{grade} ����");
    }

}

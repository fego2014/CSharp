using UnityEngine;

public class IfElsePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 85;

        if (score >= 90)
        {
            Debug.Log("�ݸ޴�");
        }
        else if (score >= 80)
        {
            Debug.Log("���޴�");
        }
        else if (score >= 70)
        {
            Debug.Log("���޴�");
        }
        else if (score <= 60)
        { 
            Debug.Log("��޴�"); 
        }
    }

}

/*
[Q]
score�� 90�̻��̸� �ݸ޴� ���, 80�̻��̸� ���޴� ���,
70�̻��̸� ���޴� ���, �׿� �������� ��޴� ���
score�� 85���̶�� �����մϴ�.

[output]
()�޴��� �����ϼ̽��ϴ�.
 */
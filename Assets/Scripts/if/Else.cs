using UnityEngine;

//
public class Else: MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 61;                //[1]

        //���� score�� 60���� ũ��
        if (score > 60)                //[2]
        {
            //���
            Debug.Log("�հ��Դϴ�.");
        }
        else //���ǽ��� �ƴϸ�
        {
            //���
            Debug.Log("���հ��Դϴ�."); //[3]
        }

        Debug.Log("���α׷� ����");     //[4]
    }


    // score
}

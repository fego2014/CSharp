using UnityEngine;

public class WhileCountdown : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]1���� 5���� 1�� ����
        //�ʱ��
        int i = 1;

        while(i<=5) //���ǽ�
        {
            //�ݺ����๮
            Debug.Log($"ī��Ʈ�ٿ�:{i}");

            //������
            i++;
        }

        Debug.Log("=============================================");


        //[2]5���� 1���� 1�� ����
        //�ʱ��
        int n = 5;

        while (n > 0)
        {
            Debug.Log($"ī��Ʈ�ٿ�:{n}");

            n--;
        }
    }

}

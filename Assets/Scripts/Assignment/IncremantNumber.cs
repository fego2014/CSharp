using UnityEngine;

// ������ ������ ���� 1 ����
public class IncremantNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //������ ���� num�� �����ϰ� 10d���� �ʱ�ȭ
        int num = 10; // num = 10

        //num = 10 + 1; // num = 11

        num = num + 1; // num 1 ������

        Debug.Log(num);
    }

}

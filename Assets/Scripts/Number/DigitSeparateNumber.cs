using UnityEngine;

// 1,000,000 -> 1_000_000 = ,(�޸�) ��ſ� _(������ھ�) ���
public class DigitSeparateNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int num = 1_000_000; //int�� ���� num�� �����ϰ� 1,000,000���� �ʱ�ȭ
        Debug.Log("num:"+num);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

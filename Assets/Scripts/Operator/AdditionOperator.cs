using UnityEngine;

// +: ���ϱ� ������ �߰� ���
public class AdditionOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("hello" + "world"); // ���ڿ� ���ϱ�
        Debug.Log("Hi" + " " + "EveryOne"); // Hi EveryOne

        Debug.Log("123" + "456");           // ���ڿ�+���ڿ�=>���ڿ� 123456
        Debug.Log("123" + 456);             // ���ڿ�+����=>���ڿ�   123456
        Debug.Log(123 + "456" + 789 + 890); // ����+���ڿ�=>���ڿ�   123456789890
        Debug.Log(123 + 456);               // ����+����=>����       579
        Debug.Log("123" + true);            // ���ڿ�+boll��=>���ڿ� 123True

        //Debug.Log("123" - 456);           // ���ڿ�-����=>����, ���ڿ����� ���ڸ� ���� ������ �Ұ���
    }

}

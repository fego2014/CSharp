using UnityEngine;


//String Interporation (���ڿ� ������)
public class StringInterporation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string message = "���ڿ� ������";

        Debug.Log("Message: " + message); //[1]���ڿ� + ����
        Debug.Log($"Message: {message}"); //[2]���ڿ� ������

        //string.Format
        string msg = string.Format("{0}��, {1}", "ȫ�浿","�ȳ��ϼ���");
        Debug.Log(msg);

    }

}

using UnityEngine;

//DefaultParameter(�⺻ �Ű�����, ������ �Ű�����): �Ű����� �����Ҷ� ���ÿ� �ʱ�ȭ�� �Ѵ�
public class DefaultParameter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //�Ű������� ���� �Լ�
        PrintMessage();

        //�Ű������� �ִ� �Լ�
        string error = "�����";
        PrintMessage(error);

        //��ȯ���� �ִ� �Լ� ȣ��
        string errorLog = PrintLog();
        Debug.Log(errorLog);
    }
    //Message�� ����ϴ� �Լ�
    void PrintMessage()
    {
        string message = "�����";
        Debug.Log(message);
    }

    void PrintMessage( string message)
    {
        Debug.Log($"����:{message}"); 
    }

    string PrintLog()
    {
        string log = "����� �α�"
        as
    }
}


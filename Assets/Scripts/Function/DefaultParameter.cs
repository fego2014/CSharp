using UnityEngine;

//DefaultParameter(기본 매개변수, 선택적 매개변수): 매개변수 선언할때 동시에 초기화도 한다
public class DefaultParameter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //매개변수가 없는 함수
        PrintMessage();

        //매개변수가 있는 함수
        string error = "디버그";
        PrintMessage(error);

        //반환값이 있는 함수 호출
        string errorLog = PrintLog();
        Debug.Log(errorLog);
    }
    //Message를 출력하는 함수
    void PrintMessage()
    {
        string message = "디버그";
        Debug.Log(message);
    }

    void PrintMessage( string message)
    {
        Debug.Log($"에러:{message}"); 
    }

    string PrintLog()
    {
        string log = "디버그 로그"
        as
    }
}


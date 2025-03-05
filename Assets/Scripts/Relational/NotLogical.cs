using UnityEngine;

//not 연산자(!) : 참이면 거짓, 거짓이면 참, (부정 연산자)
//결과: true(참), false(거짓)
public class NotLogical : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]참일때
        Debug.Log(!true); //false

        //[2]거짓일때
        Debug.Log(!false); //true

        //[3]참과 거짓을 반대로
        bool bln = false;
        Debug.Log(!bln); //true
        Debug.Log(!!bln); //false   
        Debug.Log(!!!bln); //true
        Debug.Log(!(!(!bln))); //true
    }

}

using UnityEngine;

//logical Operator(논리 연산자) - &&, ||, !
//and 연산자(&&) :두개의 조건이 모두 참일 때만 참이 되는 연산자
//결과: true(참), false(거짓)
public class AndOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 두 조건이 모두 참일 때만 참
        Debug.Log(true && true); //true

        //[2] 두 조건 중 하나라도 거짓이면 거짓
        Debug.Log(true && false); //false
        Debug.Log(false && true); //false

        //[3] 두 조건이 모두 거짓이면 거짓
        Debug.Log(false && false); //false
    }

}

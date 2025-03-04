using UnityEngine;

//Unary Operator(단항 연산자): ++,--
public class UnaryOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //int형 변수 value를 선언하고 0으로 초기화
        int value = 0;

        value = 8; //value 변수에 8을 값으로 저장 => 8
        value = +value; //value 변수에 value 변수의 값을 더한 값을 저장 => 8
        Debug.Log(value); //?

        value = -8; //value 변수에 -8을 값으로 저장 => -8
        value = +value; //value 변수에 value 변수의 값을 더한 값을 저장 => -8
        Debug.Log(value); //?

        value = 8;
        value = -value; //value 변수에 value 변수의 음수 값을 저장 => -8
        Debug.Log(value); //?

        value = -8;
        value = -value; //value 변수에 value 변수의 음수 값을 저장 => 8
        Debug.Log(value); //?

    }

}

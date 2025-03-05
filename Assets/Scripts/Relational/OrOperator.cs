using UnityEngine;

//or 연산자(||) : 두개의 조건 중 하나라도 참이면 참이 되는 연산자
//결과: true(참), false(거짓)
public class OrOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 둘다 참일때
        Debug.Log(true || true); //true

        //[2] 둘 중 하나만 참일때
        Debug.Log(false || true); //true
        Debug.Log(true || false); //true

        //[3] 둘다 거짓일때
        Debug.Log(false || false); //false

    }

}

using UnityEngine;

//Relational Operator (관계형 연산자) : 두 개의 값을 비교하는 연산자
//(==(같음), !=(다름), >(큼), <(작음), >=(크거나 같음), <=(작거나 같음)) 
//결과: true(참), false(거짓)  
public class RelationalOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        int y = 5;

        Debug.Log(x < y);  //x가 y보다 작냐? //true
        Debug.Log(x > y);  //x가 y보다 크냐? //false
        Debug.Log(x == y); //x와 y가 같냐? //false
        Debug.Log(x != y); //x와 y가 다르냐? //true
        Debug.Log(x >= y); //x가 y보다 크거나 같냐? //false
        Debug.Log(x <= y); //x가 y보다 작거나 같냐? //true

        Debug.Log("AAA" == "aaa"); //문자열은 대소문자를 구분하기 때문에 false
    }

}

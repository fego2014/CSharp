using UnityEngine;

//Postfix Operator (후위 증감연산자):(++,--) 같은 라인에서 연산하는 순위가 가장 낮은(가장 나중에 연산)
public class PostfixOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;

        int y = x++; //x를 y에 대입한 후 x를 1증가시킴

        Debug.Log("x: " + x); //x: 4
        Debug.Log("y: " + y); //y: 3
    }

}

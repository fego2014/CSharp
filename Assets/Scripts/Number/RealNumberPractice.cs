using UnityEngine;

public class RealNumberPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float ifloat = 3.14f;
        double idouble = 3.14;
        decimal idecimal = 3.14m;

        Debug.Log("float:" + ifloat);
        Debug.Log("double:" + idouble);
        Debug.Log("decimal:" + idecimal);
    }

}

/*
[Q]
�Ǽ��� �� float 3.14, double 3.14, decimal 3.14 �� ����ϱ�

[output]
float: 3.14
double: 3.14
decimal: 3.14
 */
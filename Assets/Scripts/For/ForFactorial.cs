using UnityEngine;

// 4! 값을 구하는 프로그램
public class ForFactorial : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 10;
        int fact = 1;

        for (int i = 1; 1 < n + 1; i++)
        {
            fact = fact * i;
        }
        Debug.Log($"4! 값은 {fact}");
    }

}

/*
Factorial (n!)
1! = 1
2! = 1*2
3! = 1*2*3
4! = 1*2*3*4
......
n! = 1*2*3*....*(n-1)*n

 */
using Unity.VisualScripting;
using UnityEngine;

// (연산자): +,-,*,/
// %: 나머지 연산자
public class PlusOperation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 10;
        int j = 20;
        int k=i + j;// 더하기 연산
        Debug.Log(k); // 30

        float f = 3.14f;
        float g = 3.14f;
        float e = f - g;// 빼기 연산
        Debug.Log(e); //0

        long a = 100;
        long b = 200;
        long c = a * b;// 곱하기 연산
        Debug.Log(c); //20000

        double l = 1.5;
        double m = 0.5;
        double n = l / m;// 나누기 연산
        Debug.Log(n); //3

        int x = 5;
        int y = 3;
        int z = x % y;// 나머지 연산 (몫은 버리고 나머지만 구함 (나머지2))
        Debug.Log(z); //2
    }

}

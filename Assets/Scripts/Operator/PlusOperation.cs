using Unity.VisualScripting;
using UnityEngine;

// (������): +,-,*,/
// %: ������ ������
public class PlusOperation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 10;
        int j = 20;
        int k=i + j;// ���ϱ� ����
        Debug.Log(k); // 30

        float f = 3.14f;
        float g = 3.14f;
        float e = f - g;// ���� ����
        Debug.Log(e); //0

        long a = 100;
        long b = 200;
        long c = a * b;// ���ϱ� ����
        Debug.Log(c); //20000

        double l = 1.5;
        double m = 0.5;
        double n = l / m;// ������ ����
        Debug.Log(n); //3

        int x = 5;
        int y = 3;
        int z = x % y;// ������ ���� (���� ������ �������� ���� (������2))
        Debug.Log(z); //2
    }

}

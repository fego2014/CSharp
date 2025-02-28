using UnityEngine;

// 1,000,000 -> 1_000_000 = ,(콤마) 대신에 _(언더스코어) 사용
public class DigitSeparateNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int num = 1_000_000; //int형 변수 num을 선언하고 1,000,000으로 초기화
        Debug.Log("num:"+num);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

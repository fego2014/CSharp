using System;
using UnityEngine;

public class test001 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] numbers = new int[] { 5, 3, 6, 8, 9 }; // 최소값을 구할 숫자들을 배열에 초기화
        int minValue = numbers[0]; // 배열의 첫 번째 값을 최소값으로 가정하고 시작

        // 모든 숫자를 순회하며 최소값을 찾는 반복문
        for (int i = 1; i < numbers.Length; i++) // 배열의 두 번째 요소부터 마지막 요소까지 확인
        {
            if (numbers[i] < minValue) // 현재 인덱스의 값이 현재까지의 최소값보다 작다면
            {
                minValue = numbers[i]; // 최소값을 현재 인덱스의 값으로 갱신
            }
        }

        // 결과 출력
        Debug.Log("최소값: " + minValue + "입니다"); // 찾은 최소값을 출력
    }

    
}

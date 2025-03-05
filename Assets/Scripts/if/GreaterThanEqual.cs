using UnityEngine;

//두수를 입력 받아 그중에서 큰 수를 출력하는 프로그램
public class GreaterThanEqual : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int first = 5;
        int second = 8;

        //first와 second 중 큰 수를 출력
        //만약 first가 second 이상이면 first값 출력 아니면 second값 출력
        if (first >= second)
        {
            Debug.Log($"큰 값은 {first}");
        }
        else
        {
            Debug.Log($"큰 값은 {second}");
        }
    }

}

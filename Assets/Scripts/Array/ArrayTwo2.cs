using UnityEngine;

public class ArrayTwo2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //2차원 배열 선언, 요소수 생성, 초기화
        //int[,] intarray = new int [2,3] { {1,2,3},{4,5,6} };
        //int[,] intarray = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
        int[,] intarray = { { 1, 2, 3 }, { 4, 5, 6 } };

        //배열의 길이
        Debug.Log($"배열의 길이:{intarray.Length}");

        //출력
        for (int i=0; i<intarray.GetLength(0); i++)
        {
            Debug.Log($"=================================");
            for (int j = 0; j < intarray.GetLength(1); j++)
            {
                Debug.Log(intarray[i,j]);
            }
        }

    }

}

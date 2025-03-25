using UnityEngine;
using System.Collections.Generic;

public class task1 : MonoBehaviour
{
    private int integerValue = 10;
    private float floatValue = 3.14f;
    private string stringValue = "Hello, Unity!";
    private bool booleanValue = true;

    private int[] intArray = new int[5] {1, 2, 3, 4, 5};

    private List<string> stringList = new List<string> {"First", "Second", "Third"};

    private Dictionary<string, int> inventory = new Dictionary<string, int>
    {
        {"Apples", 5},
        {"Oranges", 3},
        {"Bananas", 7}
    };

    void Start()
    {
        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = intArray[i] * 2;
        }
    }
}
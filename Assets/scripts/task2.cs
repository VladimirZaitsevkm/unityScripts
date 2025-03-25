using UnityEngine;

public class SimpleDebugExample : MonoBehaviour
{
    private int counter = 0;
    private float timer = 0f;

    void Start()
    {
        Debug.Log("Старт скрипта");
        Debug.Log($"Начальные значения: counter = {counter}, timer = {timer}");
    }

void Update()
{
    timer += Time.deltaTime;

    if (timer >= 1f)
    {
        counter++;
        Debug.Log($"Прошла {counter} секунда.");
        
        if (counter == 3)
        {
            Debug.LogWarning("Проверочная точка (3 секунды)!"); 
        }

        timer = 0f;

        if (counter >= 5)
        {
            Debug.LogError("Достигнут максимум!");
            enabled = false;
        }
    }
}

    void OnDisable()
    {
        Debug.Log("Скрипт отключен");
    }
}
using UnityEngine;

public class SegmentController : MonoBehaviour
{
    private SevenSegmentDisplay display;
    private int currentNumber = 0;

    void Start()
    {
        display = FindObjectOfType<SevenSegmentDisplay>();
        display.SetNumber(currentNumber);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            currentNumber = (currentNumber + 1) % 10; // Erhöht Zahl (0-9)
            display.SetNumber(currentNumber);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            currentNumber = (currentNumber - 1 + 10) % 10; // Verringert Zahl (0-9)
            display.SetNumber(currentNumber);
        }
    }
}
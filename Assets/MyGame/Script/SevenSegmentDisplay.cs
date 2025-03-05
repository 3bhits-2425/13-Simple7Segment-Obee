using System.Collections;
using UnityEngine;

public class SevenSegmentDisplay : MonoBehaviour
{
    // Array für alle Segmente der 7-Segment-Anzeige
    public Transform[] segments;
    private int currentNumber = 0;

    // Die Digit-Map für die Zahlen 0 bis 9
    private readonly int[][] digitMap = new int[][]
    {
        new int[] {0, 0, 0, 1, 0, 0, 0}, // 0
        new int[] {1, 1, 0, 1, 1, 0, 1}, // 1
        new int[] {0, 1, 0, 0, 0, 1, 0}, // 2
        new int[] {0, 1, 0, 0, 1, 0, 0}, // 3
        new int[] {1, 0, 0, 0, 1, 0, 1}, // 4
        new int[] {0, 0, 1, 0, 1, 0, 0}, // 5
        new int[] {0, 0, 1, 0, 0, 0, 0}, // 6
        new int[] {0, 1, 0, 1, 1, 0, 1}, // 7
        new int[] {0, 0, 0, 0, 0, 0, 0}, // 8
        new int[] {0, 0, 0, 0, 1, 0, 0}  // 9
    };

    void Start()
    {
        // Setzt alle Segmente auf eine neutrale Rotation
        for (int i = 0; i < segments.Length; i++)
        {
            segments[i].localRotation = Quaternion.identity;
        }

        // Zeigt die Startzahl (0) an
        SetNumber(0);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            currentNumber = (currentNumber + 1) % 10; // Erhöht Zahl (0-9)
            SetNumber(currentNumber);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            currentNumber = (currentNumber - 1 + 10) % 10; // Verringert Zahl (0-9)
            SetNumber(currentNumber);
        }
        {
            for (int i = 0; i <= 9; i++)
            {
                if (Input.GetKeyDown(i.ToString()) || Input.GetKeyDown((KeyCode)((int)KeyCode.Keypad0 + i)))
                {
                    SetNumber(i);
                }
            }

        }
    }


    // Methode zum Setzen der Zahl auf der Anzeige
    public void SetNumber(int number)
    {
        if (number < 0 || number > 9) return;

        for (int i = 0; i < segments.Length; i++)
        {
            bool active = digitMap[number][i] == 1;

            // Stelle sicher, dass die Standardrotation vorher zurückgesetzt wird
            segments[i].localRotation = Quaternion.identity;

            if (i == 0 || i == 3 || i == 6) // Waagerechte Segmente
            {
                segments[i].localRotation = active ? Quaternion.Euler(0, 0, 0) : Quaternion.Euler(90, 0, 0);
            }
            else // Senkrechte Segmente
            {
                segments[i].localRotation = active ? Quaternion.Euler(0, 0, 0) : Quaternion.Euler(0, 90, 0);
            }
        }
    }

}

using System.Collections;
using UnityEngine;

public class SevenSegmentDisplay : MonoBehaviour
{
    // Array für alle Segmente der 7-Segment-Anzeige
    public Transform[] segments;

    // Die Digit-Map für die Zahlen 0 bis 9
    private readonly int[][] digitMap = new int[][]
    {
        new int[] {1, 1, 1, 0, 1, 1, 1}, // 0
        new int[] {0, 0, 1, 0, 0, 1, 0}, // 1
        new int[] {1, 0, 1, 1, 1, 0, 1}, // 2
        new int[] {1, 0, 1, 1, 0, 1, 1}, // 3
        new int[] {0, 1, 1, 1, 0, 1, 0}, // 4
        new int[] {1, 1, 0, 1, 0, 1, 1}, // 5
        new int[] {1, 1, 0, 1, 1, 1, 1}, // 6
        new int[] {1, 0, 1, 0, 0, 1, 0}, // 7
        new int[] {1, 1, 1, 1, 1, 1, 1}, // 8
        new int[] {1, 1, 1, 1, 0, 1, 1}  // 9
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

    // Methode zum Setzen der Zahl auf der Anzeige
    public void SetNumber(int number)
    {
        if (number < 0 || number > 9) return;

        for (int i = 0; i < segments.Length; i++)
        {
            bool active = digitMap[number][i] == 1;

            // Stelle sicher, dass die Standardrotation vorher zurückgesetzt wird
            segments[i].localRotation = Quaternion.identity;

            if (i == 0 || i == 3 || i == 6) // Waagerechte Segmente (A, G, D)
            {
                segments[i].localRotation = active ? Quaternion.Euler(0, 0, 0) : Quaternion.Euler(0, 0, 90);
            }
            else // Senkrechte Segmente (B, C, E, F)
            {
                segments[i].localRotation = active ? Quaternion.Euler(0, 0, 0) : Quaternion.Euler(90, 0, 0);
            }
        }
    }

}

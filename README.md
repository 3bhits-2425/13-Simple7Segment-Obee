# 7-Segment-Anzeige in Unity

## ✨ Projektzusammenfassung
Dieses Projekt implementiert eine digitale **7-Segment-Anzeige** in Unity, die Zahlen von **0 bis 9** darstellen kann. Die Steuerung erfolgt über die **Pfeiltasten (Up/Down)** oder die **Num-Pad-Tasten**. Die Segmente werden durch Rotation aktiviert oder deaktiviert. Das System verwendet ein **jagged array** (unregelmäßiges Array), um die Anordnung der Segmente für jede Zahl zu speichern.

## 🔧 Jagged Arrays
Ein **Jagged Array** ist ein Array von Arrays, wobei die inneren Arrays unterschiedlich lang sein können. In diesem Projekt wird es verwendet, um die Segmentaktivierungen für jede Zahl zu definieren:

```csharp
private readonly int[][] digitMap = new int[][]
{
    new int[] {1, 1, 1, 0, 1, 1, 1}, // 0
    new int[] {0, 0, 1, 0, 0, 1, 0}, // 1
    new int[] {1, 0, 1, 1, 1, 0, 1}, // 2
    // ... weitere Zahlen
};
```




https://github.com/user-attachments/assets/44d90f91-7f04-4ec2-a3e0-0302c9deaf68


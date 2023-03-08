using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PieceColor { Black, White };

public class Checker : ScriptableObject
{
    public static float CHECKER_SIZE = 1;
    public PieceColor pieceColor;
}

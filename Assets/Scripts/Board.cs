using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Board : ScriptableObject
{
    public Stack<int>[] columns;
    public int homeSize;

    public void Init(int boardWidth)
    {
        this.homeSize = boardWidth;

        // Create new array
        columns = new Stack<int>[boardWidth * 4];
        // Initalize columns
        for (int i = 0; i < columns.Length; i++)
        {
            columns[i] = new Stack<int>();
        }
    }

    
}

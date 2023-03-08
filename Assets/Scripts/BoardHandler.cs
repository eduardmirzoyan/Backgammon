using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardHandler : MonoBehaviour
{

    [Header("Settings")]
    [SerializeField] private int boardWidth = 6;

    [Header("Data")]
    [SerializeField] private SpriteRenderer boardBackgroundSprite;
    [SerializeField] private SpriteRenderer boardBorderSprite;
    [SerializeField] private GameObject trianglePrefab;

    private void Start()
    {
        boardBackgroundSprite.transform.localScale = new Vector3(Checker.CHECKER_SIZE * (2 * boardWidth + 1), 8, 0);
        boardBorderSprite.transform.localScale = new Vector3(Checker.CHECKER_SIZE * (2 * boardWidth + 2), 9, 0);

        Vector3 position = Vector3.zero;
        // Create bottom left
        for (int i = 0; i < boardWidth; i++)
        {
            position = new Vector3(-(i + 1), -4, 0);
            Instantiate(trianglePrefab, position, Quaternion.identity);
        }

        // Create bottom right
        for (int i = 0; i < boardWidth; i++)
        {
            position = new Vector3(i + 1, -4, 0);
            Instantiate(trianglePrefab, position, Quaternion.identity);
        }

        // Create top left
        for (int i = 0; i < boardWidth; i++)
        {
            position = new Vector3(-(i + 1), 4, 0);
            Instantiate(trianglePrefab, position, Quaternion.identity).transform.Rotate(new Vector3(0, 0, 180), Space.World);
        }

        // Create top right
        for (int i = 0; i < boardWidth; i++)
        {
            position = new Vector3(i + 1, 4, 0);
            Instantiate(trianglePrefab, position, Quaternion.identity).transform.Rotate(new Vector3(0, 0, 180), Space.World); ;
        }
        
    }
}

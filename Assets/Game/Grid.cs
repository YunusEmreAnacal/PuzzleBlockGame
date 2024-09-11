using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public int columns;
    public int rows;
    public float squaresGap = 0.1f;
    public GameObject gridSquare;

    public Vector2 startPosition = new Vector2(0f, 0f);
    public float squareScale = 0.5f;
    public float everySquareOffset = 0f;

    private Vector2 _offset = new Vector2(0f, 0f);
    private List<GameObject> _gridSquares = new List<GameObject>();

    private void Start()
    {
        CreateGrid();
    }

    private void CreateGrid()
    {
        SpawnGridSquares();
        SetGridSquaresPositions();
    }

    private void SpawnGridSquares()
    {
        int square_index = 0;

        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                _gridSquares.Add(Instantiate(gridSquare) as GameObject);
                _gridSquares[_gridSquares.Count - 1].transform.SetParent(this.transform);
                _gridSquares[_gridSquares.Count - 1].transform.localScale = new Vector3(squareScale,squareScale,squareScale);
                _gridSquares[_gridSquares.Count - 1].GetComponent<GridSquare>().SetImage(square_index % 2 == 0);
                square_index++;
            }
        }
    }

    private void SetGridSquaresPositions()
    {
        int column_number = 0;
        int row_number = 0;
        Vector2 square_gap_number = new Vector2(0f,0f);
        bool row_moved = false;

        var square_rect = _gridSquares[0].GetComponent<RectTransform>();


        _offset.x = square_rect.rect.width * square_rect.transform.localScale.x + everySquareOffset;
        _offset.y = square_rect.rect.height * square_rect.transform.localScale.y + everySquareOffset;


        foreach (GameObject square in _gridSquares)
        {
            if (column_number + 1 > columns)
            {

            }
        }
    }
}

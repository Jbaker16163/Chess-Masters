using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board_Master : MonoBehaviour
{
    public GameObject Tile;
    public GameObject[] WhitePieces = null;
    public GameObject[] BlackPieces = null;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[,] BoardTiles= new GameObject[8,8];
        for(int x = 0; x < 80; x+=10)
        {
            for(int y = 0; y < 80; y+=10)
            {
                //Spawns the Tiles
                GameObject newTile = Instantiate(Tile, new Vector3(x, 0, y), Quaternion.identity);
                newTile.transform.parent = transform;

                //adds to the array
                BoardTiles[x/10,y/10] = newTile;

                //Sets their color or colour if your weird
                if (y % 20 == 0 && x % 20 == 0 || y % 20 != 0 && x % 20 !=  0)
                    newTile.GetComponent<TileMemory>().isBlack= true;
                else
                    newTile.GetComponent<TileMemory>().isBlack= false;
            }
        }
        //1 and 6 are all pawns
        for (int i = 0; i < 8; i++)
        {
            Vector3 WhitePosition = BoardTiles[i, 1].transform.position;
            WhitePosition.y += 5;
            GameObject WhitePawn = Instantiate(WhitePieces[5], new Vector3(0, 0, 0), Quaternion.identity);
            WhitePawn.transform.parent = BoardTiles[i, 1].transform;
            WhitePawn.transform.position = WhitePosition;

            Vector3 BlackPosition = BoardTiles[i, 6].transform.position;
            BlackPosition.y += 5;
            GameObject BlackPawn = Instantiate(BlackPieces[5], new Vector3(0, 0, 0), Quaternion.identity);
            BlackPawn.transform.parent = BoardTiles[i, 6].transform;
            BlackPawn.transform.position = BlackPosition;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

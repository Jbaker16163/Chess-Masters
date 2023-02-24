using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMemory : MonoBehaviour
{
    public Material WhiteMaterial;
    public bool isBlack = false;
    public Material BlackMaterial;
    public GameObject ArenaObject;
    public bool hasPiece = false;
    public GameObject Piece;

    // Start is called before the first frame update
    void Start()
    {
        if (isBlack)
            gameObject.GetComponent<Renderer>().material = BlackMaterial;
        else
            gameObject.GetComponent<Renderer>().material = WhiteMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

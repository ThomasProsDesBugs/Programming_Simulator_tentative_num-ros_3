using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable1 : MonoBehaviour
{
    public UnityEventQueueSystem OnInteract;
    public Sprite interaction;
    public Vector2 iconSize;
    public int ID;
    // Start is called before the first frame update
    void Start()
    {
        ID = Random.Range(0, 999999);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickController : MonoBehaviour
{
    public BoxCollider2D orignalBrick;
    public BoxCollider2D brokenBrick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BrickTakeDamage()
    {
        Instantiate(brokenBrick, orignalBrick.transform);
    }
}

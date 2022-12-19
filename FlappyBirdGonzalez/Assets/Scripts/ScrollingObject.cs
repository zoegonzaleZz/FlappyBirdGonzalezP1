using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour{

    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = now Vector2(GameControl.instance.scrollSpeed, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

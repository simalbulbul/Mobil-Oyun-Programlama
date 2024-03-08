using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    float xYon;
    Rigidbody2D rb;


    void Start()
    {
        Debug.Log("Merhaba Dünya");
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        yatayHareket();
    }
    private void yatayHareket()
    {
        xYon = Input.GetAxisRaw("Horizontal");
        //Input.GetButtonDown("Horizontal");
        Debug.Log(xYon);
        rb.velocity = new Vector2(xYon,0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float horizontal;
    private bool IsfaceIsright = true;

    private void Awake()
    {
       rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        this.rb.velocity = new Vector2(horizontal * 8f, this.rb.velocity.y);

        flip();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rb.AddForce(Vector2.up * 30f, ForceMode2D.Impulse);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("mickey mouse");
        }

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("i dunno");
        }
    }

    private void flip()
    {
        if (IsfaceIsright && horizontal <0f || !IsfaceIsright && horizontal > 0f) 
        {
            IsfaceIsright = !IsfaceIsright;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1;
            transform.localScale = localScale;
            Debug.Log(IsfaceIsright);
        }
    }
}
    
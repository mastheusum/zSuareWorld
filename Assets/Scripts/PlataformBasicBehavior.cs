using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformBasicBehavior : MonoBehaviour
{
    public float Speed = 0f;
    public float JumpForce = 0f;

    private bool isOnFloor = false;

    private Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rig.position += new Vector2(Input.GetAxisRaw("Horizontal"), 0f) * Speed * Time.deltaTime;
        if (isOnFloor && Input.GetAxisRaw("Jump") != 0)
        { 
            rig.AddForce(new Vector2(0f, 1f) * JumpForce, ForceMode2D.Impulse);
            isOnFloor = false;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Piso")
        {
            isOnFloor = true;
        }
    }
}

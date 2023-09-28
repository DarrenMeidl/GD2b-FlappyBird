using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//0 references
public class player : MonoBehaviour
{
    //1 reference
    public float velocity = 2.4f;
    //2 references
    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            rigidbody.velocity = Vector2.up * velocity;
        }
    }
}

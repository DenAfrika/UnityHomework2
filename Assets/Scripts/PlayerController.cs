using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float mMovementSpeed;
    Rigidbody2D rb;
    Vector2 m_Position;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        m_Position.x = Input.GetAxisRaw("Horizontal");
        m_Position.y = Input.GetAxisRaw("Vertical");
    }

    
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + m_Position * mMovementSpeed * Time.fixedDeltaTime);
    }
}

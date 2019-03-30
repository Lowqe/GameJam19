using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInput2 : MonoBehaviour
{
    private int cakeCount = 0;

    [SerializeField] private float speed;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    private Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (InputManager.AButton())
            Debug.Log("Success");

        if (InputManager.AButtonTwo())
            Debug.Log("MegaSuccess");

        Vector2 moveInput = new Vector2(Input.GetAxisRaw("2J_MainHorizontal"), Input.GetAxisRaw("2J_MainVertical"));
        moveVelocity = moveInput.normalized * speed;

        if (moveInput.magnitude == 0)
        {
 //           anim.SetBool("isMoving", false);
        }
        else
        {
  //          anim.SetBool("isMoving", true);
        }

        if (cakeCount > 0 && Input.GetKeyDown(KeyCode.Space))
        {
            speedBoost();
        }

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }

    public void AddCake()
    {
        cakeCount++;
    }
    public int GetNumberOfCakes()
    {
        return cakeCount;
    }

    // if cakecount <0 and keydown x speed upp i x antal sekunder
    private void speedBoost()
    {
        speed = 14f;
    }
}

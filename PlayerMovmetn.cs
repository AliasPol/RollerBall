using UnityEngine;
using System.Collections;

public class PLayerMovment : MonoBehaviour {

    public float playerSpeed = 1;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();


    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        moveHorizontal = MoveChan(moveHorizontal);
        moveVertical = MoveChan(moveVertical);

        Vector3 movment = new Vector3(moveHorizontal, 0.0f, moveVertical);


        rb.AddForce(movment * playerSpeed * Time.deltaTime);
    }

    float MoveChan(float moveVH)
    {
        if (moveVH != 0)
        {
            if (moveVH > 0)
            {
                moveVH = 1;
            }
            else
            {
                moveVH = -1;
            }
        }
        return moveVH;
    }

}

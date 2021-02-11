using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float moveSpeed = 5.0f;
    float rotateSpeed = 250f;

    public Animator playerAnim;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
            playerAnim.SetBool("isRun", true);
        }
        else if(Input.GetKeyUp(KeyCode.W))
        {
            playerAnim.SetBool("isRun", false);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, Time.deltaTime * rotateSpeed, 0));
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
            playerAnim.SetBool("isRun", true);
        }
        else if(Input.GetKeyUp(KeyCode.S))
        {
            playerAnim.SetBool("isRun", false);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, Time.deltaTime * -rotateSpeed, 0));
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerAnim.SetTrigger("trigJump");
        }
    }
}

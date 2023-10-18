using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePersonnage : MonoBehaviour
{
    private Rigidbody instanceRigibody;

    public float jumpForce = 12.0f;
    bool grounded = true;

    // Start is called before the first frame update
    void Start()
    {
        instanceRigibody = GetComponent<Rigidbody>();

        Physics.gravity *= 3;
        
    }

    // Update is called once per frame
    void Update()
    {



    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) && grounded == true)
        {
            Debug.Log("JUMP");
            instanceRigibody.AddForce(jumpForce * Vector3.up, ForceMode.Impulse);
            grounded = false;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision != null)
        {
            Debug.Log("COLIDE");
            grounded = true;
        }
    }
}

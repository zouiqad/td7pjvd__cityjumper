using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public GameObject obstacle;

    private GameObject background;
    private GameObject ground;

    private float minX;
    public float moveSpeed = 1.0f;
    private Vector3 position = 2.0f * Vector3.right;

    // Start is called before the first frame update
    void Start()
    {
        ground = GameObject.Find("Ground");
        background = GameObject.Find("Background");

        MeshRenderer groundMesh = ground.GetComponent<MeshRenderer>();

        // get ground boundaries
        minX = groundMesh.bounds.min.x;


        InvokeRepeating("SpawnObstacle", 0.0f, 1.0f);
        InvokeRepeating("SpawnObstacle", 0.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        MoveBackground();
        
    }

    private void SpawnObstacle()
    {
        Instantiate(obstacle, position, Quaternion.identity);
        position.x += 2.0f;
    }

    private void MoveBackground()
    {
        background.transform.Translate(-1 * Vector3.right * Time.deltaTime * moveSpeed);
        moveSpeed += 0.1f;
    }
    
}

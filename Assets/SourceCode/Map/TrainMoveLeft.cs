using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TrainMoveLeft : MonoBehaviour
{
    [SerializeField] private float speed = 0.25f;
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        rb.AddRelativeForce(Vector3.right * speed, ForceMode.Impulse);
        if (rb.position.x > 100)
        {
            Destroy(rb.gameObject);
        }
    }
}

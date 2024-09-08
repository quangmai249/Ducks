using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    private Vector3 default_location;
    [SerializeField] float speedBg = 0.1f;
    private void Start()
    {
        default_location = transform.position;
    }
    void Update()
    {
        gameObject.transform.Translate(Vector3.left * speedBg);
        if (gameObject.transform.position.x < -default_location.x * 1.25)
        {
            gameObject.transform.position = default_location;
        }
    }
}

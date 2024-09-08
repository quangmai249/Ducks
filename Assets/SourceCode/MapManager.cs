using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{

    [SerializeField] float zRangeNew = -0.1f;
    [SerializeField] float zRangeTimeChange = 0.25f;
    private Vector3 default_loca;
    private void Start()
    {
        default_loca = transform.position;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Duck"))
        {
            transform.position = NewPosWhenTriggerDuck();
            StartCoroutine(nameof(GetBackLocationDefaultDuck));
        }
    }
    Vector3 NewPosWhenTriggerDuck()
    {
        return new Vector3(transform.position.x, transform.position.y, zRangeNew);
    }
    IEnumerator GetBackLocationDefaultDuck()
    {
        yield return new WaitForSeconds(zRangeTimeChange);
        transform.position = default_loca;
    }
}

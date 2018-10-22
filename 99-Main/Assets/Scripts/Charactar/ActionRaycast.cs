using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionRaycast : MonoBehaviour
{
    private Ray ray;

    void Start()
    {
        ray = new Ray();
    }

    // Update is called once per frame
    void Update()
    {
        ray.origin = transform.position;
        ray.direction = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;

        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 100, Color.yellow);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            //Rayが当たるオブジェクトがあった場合はそのオブジェクト名をログに表示
            Debug.Log(hit.collider.gameObject.name);

            //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
        }
    }
}

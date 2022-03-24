using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadsWillRoll : MonoBehaviour
{
    public float minHeight = 0.38f;
    public float maxHeight = 0.4f;

    public float rotationSpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        float diff = maxHeight - minHeight;
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, minHeight + (Mathf.Sin(Time.time) * diff));
        Vector3 eular = transform.localRotation.eulerAngles;
        transform.Rotate(new Vector3(eular.x, eular.y, rotationSpeed * Time.deltaTime), Space.Self);
    }
}

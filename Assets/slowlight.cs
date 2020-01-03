using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowlight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, MovementController.pos, Time.deltaTime / 10.0f);
    }
}

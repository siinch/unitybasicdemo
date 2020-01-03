using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granade : MonoBehaviour
{

    public GameObject particles; 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision) {
      Instantiate(particles, transform.position, Quaternion.identity);
      Destroy(gameObject);
    }
}

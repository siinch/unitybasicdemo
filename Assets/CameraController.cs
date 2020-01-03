using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform characterBase;
    public float lookSpeed = 10f;
    public GameObject granade;

    private float _camRotation;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float y = Input.GetAxis("Mouse Y");
        float x = Input.GetAxis("Mouse X");

        _camRotation -= y * lookSpeed * Time.deltaTime * 10f;
        _camRotation = Mathf.Clamp(_camRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(_camRotation , 0f ,0f);

        characterBase.Rotate(x * lookSpeed * Time.deltaTime * 10f * Vector3.up);

        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        if(Input.GetMouseButtonDown(0))
          if(Physics.Raycast(transform.position, fwd, out hit, 3))
            if(hit.transform.tag == "target")
              Destroy(hit.transform.gameObject);

        if(Input.GetMouseButtonDown(1)) {
          var temp = Instantiate(granade, transform.position + fwd, Quaternion.identity);
          temp.GetComponent<Rigidbody>().AddForce(fwd * 500.0f);
        }
        /*
        if(Input.GetMouseButton(0))
            Cursor.lockState = CursorLockMode.Locked;

        if(Input.GetKeyDown(KeyCode.Escape))
            Cursor.lockState = CursorLockMode.Confined;
        */
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
          SceneManager.LoadScene(0);
          Debug.Log("load scene");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2)) {
          SceneManager.LoadScene(1);
          Debug.Log("load scene");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject playerGo;
    Vector3 CameraOffSet;

    // Start is called before the first frame update
    void Start()
    {
        CameraOffSet = new Vector3(0 , 2, -2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerGo.transform.position + CameraOffSet;
    }
}

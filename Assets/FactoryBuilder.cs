using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryBuilder : MonoBehaviour
{
    Vector3 clickPosition;

    [SerializeField]
    GameObject factory;

    [SerializeField]
    Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //on click, spawn a factory on click location
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            clickPosition = Input.mousePosition;
            Ray ray = mainCamera.ScreenPointToRay(clickPosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Instantiate(factory, hit.point, Quaternion.identity);
            }
            
            
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    FactoryCounter factoryCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //find the script and increment the count
    private void Awake()
    {
        factoryCounter = GameObject.Find("Text (TMP)").GetComponent<FactoryCounter>();
        factoryCounter.numFactories += 1;
    }


}

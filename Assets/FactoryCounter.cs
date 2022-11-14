using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FactoryCounter : MonoBehaviour
{
    public int numFactories;
    TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        text = this.gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        //display current factory count
        text.text = $"{numFactories}";
    }
}

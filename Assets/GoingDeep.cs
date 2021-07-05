using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoingDeep : MonoBehaviour
{
    public Material original_material;
    public Material strike_material;
    public Text warning;
    public LifeCounter lifeCounter;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            warning.text = "Be careful, you are going too deep";
            GetComponent<Renderer>().material = strike_material;
            lifeCounter.lifes -= 1;
        }
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            warning.text = " ";
            GetComponent<Renderer>().material = original_material;
        }
    }

}
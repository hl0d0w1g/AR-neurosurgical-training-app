using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchingTumour : MonoBehaviour
{
    public Material original_material;
    public Material strike_material;
    public Text warning;
    public PlayerState playerState;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            warning.text = "Congratulations, you have successfully accessed the tumour";
            GetComponent<Renderer>().material = strike_material;
            
            if(playerState.error == 0)
            {
                warning.text = "Congratulations, you have successfully accessed the tumour";
                GetComponent<Renderer>().material = strike_material;
            }
            else
            {
                warning.text = "";//"Be careful! You have not accessed the tumor properly";
            }
            
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
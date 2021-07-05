using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;

public class Touching : MonoBehaviour
{
    public Material original_material;
    public Material strike_material;
    public Text warning;
    public PlayerState playerState;
    public LifeCounter lifeCounter;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        { 
            //GetComponent<Renderer>().material = strike_material;
            playerState.error += 1;
            lifeCounter.lifes -= 1;
            warning.text = "Congratulations, you have successfully accessed the tumour";//"Be careful, you are touching the " + gameObject.name;
            //await Task.Delay(2000); 

        }
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            warning.text = " ";
            GetComponent<Renderer>().material = original_material;
            playerState.error -= 1;
        }

    }

}

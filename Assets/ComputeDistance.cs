using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputeDistance : MonoBehaviour
{

    public GameObject needle;
    public GameObject tumour;
    private float distance;
    public Text distanceText;
    public LineRenderer lineRender;

    // Start is called before the first frame update
    void Start()
    {
        distanceText.gameObject.SetActive(false);
        lineRender = GetComponent<LineRenderer>();
        SetDistance();        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 aux = new Vector3(0.0f, 0.0f, -310.0f);
        Vector3 needlo_pos = needle.transform.position + aux;
        lineRender.SetPosition(0, needle.transform.position);
        lineRender.SetPosition(1, tumour.transform.position);


        distance = Vector3.Distance(needle.transform.position, tumour.transform.position);
        SetDistance();
    }

    void SetDistance()
    {
        distanceText.text = "Distance to the target point: " + distance.ToString();
    }

}

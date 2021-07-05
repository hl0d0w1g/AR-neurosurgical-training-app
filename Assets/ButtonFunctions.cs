using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonFunctions : MonoBehaviour
{
    public int pushes = 0;
    public ComputeDistance computeDistance;

    // LOADING GAME OBJECTS:

    public GameObject frontal_cortex_izq;
    public GameObject frontal_cortex_der;
    public GameObject frontal_cortex_cen;

    public GameObject parietal_cortex_izq;
    public GameObject parietal_cortex_der;

    public GameObject temporal_cortex_izq;
    public GameObject temporal_cortex_der;

    public GameObject white_matter;

    public GameObject cerebellum;

    public GameObject internal_brain;

    public GameObject occipital_cortex;

    // LOADING MATERIALS:

    public Material frontal_cortex_mat;
    public Material temporal_cortex_mat;
    public Material parietal_cortex_mat;
    public Material occipital_cortex_mat;
    public Material white_matter_mat;
    public Material cerebellum_mat;
    public Material internal_brain_mat;

    public Material neutral_mat;

    public Material transparent_material;
    public Material line_material;

    // TEXT BOXES:
    public Text distanceText;

    // FUNCTIONS:

    public void ShowRegions()
    {
        if (pushes == 0)
        {
            frontal_cortex_izq.GetComponent<Renderer>().material = frontal_cortex_mat;
            frontal_cortex_der.GetComponent<Renderer>().material = frontal_cortex_mat;
            frontal_cortex_cen.GetComponent<Renderer>().material = frontal_cortex_mat;

            temporal_cortex_izq.GetComponent<Renderer>().material = temporal_cortex_mat;
            temporal_cortex_der.GetComponent<Renderer>().material = temporal_cortex_mat;

            parietal_cortex_izq.GetComponent<Renderer>().material = parietal_cortex_mat;
            parietal_cortex_der.GetComponent<Renderer>().material = parietal_cortex_mat;

            white_matter.GetComponent<Renderer>().material = white_matter_mat;

            cerebellum.GetComponent<Renderer>().material = cerebellum_mat;

            internal_brain.GetComponent<Renderer>().material = internal_brain_mat;

            occipital_cortex.GetComponent<Renderer>().material = occipital_cortex_mat;
        }

        if(pushes == 1)
        {
            computeDistance.lineRender.material = line_material;
            distanceText.gameObject.SetActive(true);
        }

        if (pushes == 2)
        {
            frontal_cortex_izq.GetComponent<Renderer>().material = neutral_mat;
            frontal_cortex_der.GetComponent<Renderer>().material = neutral_mat;
            frontal_cortex_cen.GetComponent<Renderer>().material = neutral_mat;

            temporal_cortex_izq.GetComponent<Renderer>().material = neutral_mat;
            temporal_cortex_der.GetComponent<Renderer>().material = neutral_mat;

            parietal_cortex_izq.GetComponent<Renderer>().material = neutral_mat;
            parietal_cortex_der.GetComponent<Renderer>().material = neutral_mat;

            white_matter.GetComponent<Renderer>().material = neutral_mat;

            cerebellum.GetComponent<Renderer>().material = neutral_mat;

            internal_brain.GetComponent<Renderer>().material = neutral_mat;

            occipital_cortex.GetComponent<Renderer>().material = neutral_mat;

            computeDistance.lineRender.material = transparent_material;

            distanceText.gameObject.SetActive(false);

        }

        if (pushes < 2)
        {
            pushes += 1;
        }
        else
        {
            pushes = 0;
        }

        print(pushes);
    }













}

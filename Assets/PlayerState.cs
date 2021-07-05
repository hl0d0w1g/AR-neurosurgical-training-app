using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{

    public int error = 0;

    public void SumarError()
    {
        error += 1;
    }
    public void RestarError()
    {
        error -=1;
    }

}

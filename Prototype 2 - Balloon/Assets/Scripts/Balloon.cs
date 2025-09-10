using UnityEngine;
using System.Collections.Generic;
using System.Collections;
public class Balloon : MonoBehaviour
{

    public int clickToPop = 3;

    public float scaleToIncrease = 0.15f;

    public int scoreToGive;

    private ScoreManager scoreManager;

    public GameObject popEffect;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        // reduce clicks by one
        clickToPop -= 1;
        //increase balloon size
        transform.localScale += Vector3.one * scaleToIncrease;
        //check to see if the balloon has popped
        if (clickToPop == 0)
        {
            Destroy(gameObject); // pop balloon
        }
    }
}

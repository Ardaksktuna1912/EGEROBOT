using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLight : MonoBehaviour
{
    public GameObject Light;
    private bool on = false;
    public Animator anim;


    void Start()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKeyDown(KeyCode.E) && !on)
        {
            anim.SetBool("OpenLight", true);
            Debug.Log("a");    
            Light.SetActive(true);
            on = true;


        }
        else if (other.tag == "Player" && Input.GetKeyDown(KeyCode.E) && on)
        {
            anim.SetBool("OpenLight", true);

            Light.SetActive(false);
            on = false;

        }

        else
        {
            anim.SetBool("OpenLight", false);
        }
    }


}

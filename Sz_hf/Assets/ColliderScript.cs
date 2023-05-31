using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    public bool OnTheGround { get; set; }
    public bool InFirstRow { get; set; }
    public bool InSecondRow { get; set; }

    void Start()
    {
        OnTheGround = false;
        InFirstRow = false;
        InSecondRow = false;
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            Debug.Log("A foldon vagyok!");
            OnTheGround = true;
        }
        if(collision.gameObject.name == "Ground1" || collision.gameObject.name == "Ground2" || collision.gameObject.name == "Ground3")
        {
            InFirstRow=true;
        }
        if(collision.gameObject.name == "FirstRow1" || collision.gameObject.name == "FirstRow2")
        {
            InSecondRow=true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            OnTheGround = false;
        }
        if (collision.gameObject.name == "Ground1" || collision.gameObject.name == "Ground2" || collision.gameObject.name == "Ground3")
        {
            InFirstRow = false;
        }
        if (collision.gameObject.name == "FirstRow1" || collision.gameObject.name == "FirstRow2")
        {
            InSecondRow = false;
        }
    }


}

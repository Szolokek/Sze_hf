using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingLogic : MonoBehaviour
{

    public ColliderScript ground1;
    public ColliderScript ground2;
    public ColliderScript ground3;
    public ColliderScript firstRow1;
    public ColliderScript firstRow2;
    public ColliderScript top;

    private bool ground_done = false;
    private bool middle_done = false;
    private bool top_done = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ground1.OnTheGround && ground2.OnTheGround && ground3.OnTheGround)
        {
            ground_done = true;
        }
        else
        {
            ground_done=false;
        }

        if((!firstRow1.OnTheGround && !firstRow2.OnTheGround) && (firstRow1.InFirstRow && firstRow2.InFirstRow))
        {
            middle_done = true;
        }
        else
        {
            middle_done=false;
        }

        if(top.InSecondRow && !top.InFirstRow && !top.OnTheGround)
        {
            top_done = true;
        }
        else
        {
            top_done = false;
        }

        if(ground_done && middle_done && top_done)
        {
            ReturnToMenu.end_screen = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class LifeCycleSystem : MonoBehaviour
{
   
    public Text text;
    public int DayCount = 0;

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      
        for (int i = 0; i<=4; i++)
        {
            if (this.animator.GetCurrentAnimatorStateInfo(0).IsName(""+i))
            {
                DayCount = i;
                text.text = "Day :" + DayCount;
            }
        }
    }
}

/* if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("1"))
       {
           DayCount = 1;
           text.text = "Day :" + DayCount;
       }
       if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("2"))
       {
           DayCount = 2;
           text.text = "Day :" + DayCount;
       }
       if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("3"))
       {
           DayCount = 3;
           text.text = "Day :" + DayCount;
       }
       if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("4"))
       {
           DayCount = 4;
           text.text = "Day :" + DayCount;
       }*/

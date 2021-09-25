using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class AnimationStateController : MonoBehaviour
{
    private Animator animator;

    private int walkingState = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool wPressed = Input.GetKey("w");
        if (wPressed)
        {
            walkingState = 2;
            animator.SetInteger("WalkingState", walkingState);
        }
        else if (!wPressed)
        {
            walkingState = 1;
            animator.SetInteger("WalkingState", walkingState);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    int isRunningHash;
    int isFastRunningHash;

    void Start()
    {
        animator = GetComponent<Animator>();
        isRunningHash = Animator.StringToHash("isRunning");
        isFastRunningHash = Animator.StringToHash("isFastRunning");
    }

    void Update()
    {
        bool isfastrunning = animator.GetBool(isFastRunningHash);
        bool isRunning = animator.GetBool(isRunningHash);
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");

        if (!isRunning && forwardPressed)
        {
            animator.SetBool(isRunningHash, true);
        }

        if (isRunning && !forwardPressed)
        {
            animator.SetBool(isRunningHash, false);
        }

        if (!isfastrunning && (forwardPressed && runPressed))
        {
            animator.SetBool(isFastRunningHash, true);
        }

        if (isfastrunning && (!forwardPressed || !runPressed))
        {
            animator.SetBool(isFastRunningHash, false);
        }
    }
}

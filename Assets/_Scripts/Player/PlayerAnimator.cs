using System;
using System.Collections;
using System.Collections.Generic;
using EmreBeratKR.ServiceLocator;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private const string IS_WALKING = "isWalking";
    private static readonly int IS_WALKING_HASH = Animator.StringToHash(IS_WALKING);
    
    
    private Animator animator;

    
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    
    private void Update()
    {
        // animator.SetBool(IS_WALKING, Player.Instance.IsWalking());
        animator.SetBool(IS_WALKING_HASH, Player.Instance.IsWalking());
        
    }
}

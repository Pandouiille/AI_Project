using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem.iOS;

public class Attack : StateMachineBehaviour
{
    public static event Action OnAttack;

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        OnAttack?.Invoke();
    }
}

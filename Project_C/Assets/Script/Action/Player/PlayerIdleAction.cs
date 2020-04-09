﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleAction : CharacterAction
{
    public static CharacterAction Instance = new PlayerIdleAction();

    public override void StartAction(Character owner)
    {
        base.StartAction(owner);
        AnimUtil.PlayAnim(owner, "idle");
    }

    public override void UpdateAction()
    {
        base.UpdateAction();

        if (PlayerUtil.GetAttackInput())
        {
            Owner.CurrentAction = PlayerAttackAction.Instance;
            return;
        }

        if(Input.GetKeyDown(KeyCode.I))
        {
            Owner.CurrentAction = PalyerCustom2Action.Instance;
        }

        Vector3 velocity = PlayerUtil.GetVelocityInput();

        if (velocity.magnitude > 0.1f)
        {
            Owner.CurrentAction = PlayerMoveAction.Instance;
            return;
        }
    }
}
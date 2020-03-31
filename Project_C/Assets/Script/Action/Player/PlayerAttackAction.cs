﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackAction : CharacterAction
{
    public static CharacterAction Instance = new PlayerAttackAction();

    Vector3 originPos;

    public override void StartAction(Character owner)
    {
        base.StartAction(owner);
        AnimUtil.PlayAnim(owner, "attack");
        originPos = Owner.transform.position;
    }

    public override void UpdateAction()
    {
        base.UpdateAction();

        Owner.transform.position = Vector3.Lerp(originPos, 
            originPos + 0.5f * Owner.transform.forward * Isometric.IsometricTileSize.x, 
            Mathf.Min(AnimUtil.GetAnimNormalizedTime(Owner) * 2f, 1f));

        if (AnimUtil.IsLastFrame(Owner))
        {
            Owner.CurrentAction = PlayerIdleAction.Instance;
            return;
        }
    }
}

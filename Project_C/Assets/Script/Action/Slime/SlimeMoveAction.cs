using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SlimeMoveAction : CharacterAction
{

public static SlimeMoveAction GetInstance() { return new SlimeMoveAction(); }

public override void StartAction(Character owner)
{
base.StartAction(owner);
NodeUtil.PlayAnim(Owner ,"run");
NodeUtil.MoveToPlayer(Owner);
}

public override void UpdateAction()
{
base.UpdateAction();

if(NodeUtil.HitDeadLogicMacro(Owner ,"SlimeHitAction" ,"SlimeDeadAction"))
{
}

else
{
NodeUtil.LookPlayer(Owner);
NodeUtil.RotationAnim(Owner ,"run");

if(NodeUtil.PlayerInRange(Owner ,0.7f))
{
NodeUtil.ChangeAction(Owner ,"SlimeAttackAction");
}

else
{
NodeUtil.MoveToPlayer(Owner);
}
}
}

public override void FinishAction()
{
base.FinishAction();
NodeUtil.StopMovement(Owner);
}
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CSlimeAttackAction : CharacterAction
{

public static CSlimeAttackAction GetInstance() { return new CSlimeAttackAction(); }

public override void StartAction(Character owner)
{
base.StartAction(owner);
TimelineEvents.Add(new TimeLineEvent(0.7f, TimeLine_4));
NodeUtil.PlayAnim(Owner ,"idle");
}

public override void UpdateAction()
{
base.UpdateAction();

if(NodeUtil.HitDeadLogicMacro(Owner ,"CSlimeHitAction" ,"CSlimeDeadAction"))
{
}

else
{

if(NodeUtil.IsLastFrame(Owner))
{
NodeUtil.ChangeAction(Owner ,"CSlimeIdleAction");
}

else
{
}
}
}

public override void FinishAction()
{
base.FinishAction();
}

void TimeLine_4()
{
NodeUtil.TakeDamageToPlayer(10f);
}
}

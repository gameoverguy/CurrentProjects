using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FireBall : Ability
{
	public int fireballDamage;
	[SerializeField]private TargetingSystem targetingSystem;
	
	public override void Activate(GameObject parent)
	{
		targetingSystem = parent.GetComponent<TargetingSystem>();
		//targetingSystem.FindOppositeTarget(parent);
		//targetingSystem.FindRandomTarget(parent);
		targetingSystem.FindAllTargets(parent);
		//DamageTarget();
		DamageAllTargets();
	}
	
	private void PlayAnimation()
	{
		
	}
	
	private void DamageTarget()
	{
		if(targetingSystem.targetCard != null)
		{
			targetingSystem.targetCard.card.health -= fireballDamage;
		}
	}
	
	
	private void DamageAllTargets()
	{
		if(targetingSystem.targetCards.Count != 0)
		{
			foreach (CardController cardController in targetingSystem.targetCards)
			{
				cardController.card.health -= fireballDamage;
			}
		}
		targetingSystem.targetCards.Clear();
	}
	
	private void DamageMultipleTargets()
	{
		
	}
	
	
	
}


















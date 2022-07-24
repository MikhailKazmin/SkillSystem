using UnityEditor;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public abstract class Skill : ScriptableObject, ISkill
{
    [SerializeField] protected int _ID;
    [SerializeField] protected AbilityType _abilityType;
    [SerializeField] protected AbilityBehavior _abilityBehavior;
    [SerializeField] protected bool _abilityIsUltimate;
    protected bool IsRefresh = false;

    public Skill GetStatsSkill()
    {
        return this;
    }
    public int ID { get => _ID; }
    public AbilityType AbilityType { get => _abilityType; }
    public AbilityBehavior AbilityBehavior { get => _abilityBehavior; }
    public bool AbilityIsUltimate { get => _abilityIsUltimate; }
    public abstract IEnumerator OnRefresh();
    public abstract void OnSpellStart();
    public virtual void OnCast()
    {
        if (!IsRefresh) Debug.Log("Don'tSkillRefresh");//
        else
        {
            View.PrintPropertiesSkill.Invoke();
            IsRefresh = false;
            OnSpellStart();
        }
    }
}

public enum AbilityType
{
    Ability_Type_Target,
    Ability_Type_No_Target,
    Ability_Type_Passive
}
public enum AbilityBehavior
{
    Ability_Behavior_Root_Disabled,
    Ability_Behavior_Ignor_Cast,
    Ability_Behavior_Ignor_Stun
}



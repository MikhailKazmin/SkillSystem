using System.Collections;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(menuName = "UltimateSkill", fileName = "New UltimateSkill")]
public class UltimateSkill : Skill
{

    [SerializeField] protected float _abilityPreCastPoint;
    [SerializeField] protected float _abilityPostCastPoint;
    
    protected float _abilityСharge = 0f;
    public float AbilityСharge { get => _abilityСharge; }
    public float AbilityPreCastPoint { get => _abilityPreCastPoint; }
    public float AbilityPostCastPoint { get => _abilityPostCastPoint; }
    

    public override IEnumerator OnRefresh()
    {
        while (_abilityСharge != 100f)
        {
            yield return new WaitForSeconds(1f);
            _abilityСharge++;
        }
        IsRefresh = true;
        Debug.Log($"SkillRefresh({this.name})");//
    }

    public override void OnSpellStart()
    {
        _abilityСharge = 0;
        Debug.Log($"OnSpellStart({this.name})");//
    }
}

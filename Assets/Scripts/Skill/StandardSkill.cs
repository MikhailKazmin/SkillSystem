using System.Collections;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(menuName = "StandardSkill", fileName = "New StandardSkill")]
public class StandardSkill : Skill
{
    [SerializeField] protected float _abilityCooldown;
    public float AbilityCooldown { get => _abilityCooldown; }

    public override IEnumerator OnRefresh()
    {
        yield return new WaitForSeconds(_abilityCooldown);
        IsRefresh = true;
        Debug.Log($"SkillRefresh({this.name})");//
    }

    public override void OnSpellStart()
    {
        Debug.Log($"OnSpellStart({this.name})");//
    }
}

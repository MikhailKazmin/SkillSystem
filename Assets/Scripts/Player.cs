using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] private Dictionary<int, ISkill> _skills = new Dictionary<int, ISkill>();
    [SerializeField] private SkillController _skillController;

    private void Awake()
    {
        if (_skills == null) _skills = new Dictionary<int, ISkill>();

        foreach (var item in GetSkills()) _skills.Add(item.ID, item);

        _skillController.Init(_skills);
    }

    private List<Skill> GetSkills()
    {
        List<Skill> skillsList = new List<Skill>();
        skillsList.AddRange(Resources.LoadAll<Skill>("Skills"));
        return skillsList;
    }
}

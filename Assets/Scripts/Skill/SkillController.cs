using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillController : MonoBehaviour
{
    [SerializeField] private Dictionary<int,ISkill> skills = new Dictionary<int, ISkill>();
    [SerializeField] private View Viewer;

    public void Init(Dictionary<int, ISkill> skills)
    {
        this.skills = skills;
        foreach (var item in this.skills)
        {
            StartCoroutine(item.Value.OnRefresh());
        }
        Viewer.Init(skills);
    }
}

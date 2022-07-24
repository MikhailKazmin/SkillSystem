using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class View : MonoBehaviour
{
    protected Dictionary<int, ISkill> _skills;
    public static Action PrintPropertiesSkill;
    public void Init(Dictionary<int, ISkill> skills)
    {
        if (_skills == null) _skills = new Dictionary<int, ISkill>();
        this._skills = skills;
        PrintPropertiesSkill += PrintProperties;
    }

    protected void UseSkill(int id)
    {
        try
        {
            if (_skills[id] != null)
            {
                _skills[id].OnCast();
                StartCoroutine(_skills[id].OnRefresh());
            }
            else Debug.Log("EmptySkill");
        }
        catch (Exception ex)
        {
            Debug.Log($"ID = {id}");
            Debug.Log(ex.Message);
        }
    }

    protected virtual void PrintProperties()
    {
        Debug.Log("PrintPropertiesSkill");
    }
}

using System;
using System.Collections;

public interface ISkill
{
    IEnumerator OnRefresh();
    void OnSpellStart();
    void OnCast();
    Skill GetStatsSkill();
}


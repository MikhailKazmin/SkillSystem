using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewInputKeyboard : View
{
    [SerializeField] private List<KeyCode> _keysSkills;

    private void Update()
    {
        if (_skills == null) return;
        for (int i = 0; i < _keysSkills.Count; i++)
        {
            int ID = i;
            ID++;
            if (Input.GetKeyDown(_keysSkills[i])) UseSkill(ID);
        }
    }
}

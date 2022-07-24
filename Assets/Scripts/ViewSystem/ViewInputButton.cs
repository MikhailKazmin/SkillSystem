using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewInputButton : View
{
    [SerializeField] private List<Button> _buttonsSkills;


    private void Start()
    {
        if (_skills == null) return;

        for (int i = 0; i < _buttonsSkills.Count; i++)
        {
            int ID = i;
            ID++;
            _buttonsSkills[i].onClick.AddListener(() => UseSkill(ID));
        }
    }
}

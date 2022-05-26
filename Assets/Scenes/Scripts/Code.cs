using System;
using System.Collections;
using System.Collections.Generic;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class Code : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField textUi;
    
    [SerializeField]
    private GameObject[] boxes;

    private ScriptEngine _engine = Python.CreateEngine();
    private ScriptScope _scope;
    
    [SerializeField] 
    private Button btnExecute;
    private int _counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        _scope = _engine.CreateScope();
        foreach (var box in boxes)
        {
            var tmpBoxManipulate = box.GetComponent<BoxManipulate>();
            _scope.SetVariable(tmpBoxManipulate._name, tmpBoxManipulate);
        }
        btnExecute.onClick.AddListener(OnClickEvent);
    }

    private void OnClickEvent()
    {
        var code = textUi.text;
        try
        {
            _engine.Execute(code, _scope);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}

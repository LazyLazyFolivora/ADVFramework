﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePanel : MonoBehaviour
{
    private static SavePanel instance;

    public static SavePanel GetInstance
    {
        get { return instance; }
    }

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// SaveLoadGUI状态机切换到该UI时触发
    /// </summary>
    public void OnEnter()
    {

    }

    /// <summary>
    /// 从该UI切换到另一个UI时触发
    /// </summary>
    public void OnLeave()
    {

    }
}

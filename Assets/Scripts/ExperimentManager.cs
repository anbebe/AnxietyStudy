using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class ExperimentManager
{
    public enum Scene
    {
        StartScene, StressScene, CalmingScene, SelfReportScene
    }
    
    public static Guid userGuid = System.Guid.NewGuid();

    public static bool calmingSetup = false;

    public static void Load(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }

}

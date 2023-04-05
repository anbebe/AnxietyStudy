using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class ExperimentManager
{
    public enum Scene
    {
        StartScene, StressScene, CalmingScene, SelfReportScene, NeutralScene
    }
    
    public static Guid userGuid = System.Guid.NewGuid();
    public static bool calmingSetup = false;
    public static List<Scene> sceneOrder = new List<Scene>();
    public static List<string> selfReports =  new List<string>();

    public static void LoadNextScene()
    {
        SceneManager.LoadScene(sceneOrder[0].ToString());
        sceneOrder.RemoveAt(0);
    }

    public static void SetSceneList()
    {
        if (calmingSetup)
        {
            sceneOrder = new List<Scene>() {Scene.SelfReportScene, Scene.StressScene,Scene.SelfReportScene, Scene.CalmingScene, Scene.SelfReportScene} ;
        }
        else
        {
            sceneOrder = new List<Scene>() {Scene.SelfReportScene, Scene.StressScene,Scene.SelfReportScene, Scene.NeutralScene, Scene.SelfReportScene} ;
        }
    }

    public static void AddSelfReport(int val)
    {
        selfReports.Add(SceneManager.GetActiveScene().ToString() + "," + val.ToString());
    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public static class ExperimentManager
{
    public enum Scene
    {
        StartScene, StressScene, CalmingScene, SelfReportScene, NeutralScene, TextScene
    }
    public static WriteCSV writeCsv = new WriteCSV();
    public static Guid userGuid = System.Guid.NewGuid();
    public static bool calmingSetup = false;
    public static List<Scene> sceneOrder = new List<Scene>();
    public static List<string> selfReports =  new List<string>();
    private static int reportCounter = 0;

    public static void LoadNextScene()
    {
        if (sceneOrder.Count > 0)
        {
            SceneManager.LoadScene(sceneOrder[0].ToString());
            sceneOrder.RemoveAt(0);
        }
        else
        {
            QuitAndSave();
        }
        
    }

    public static void SetSceneList()
    {
        if (calmingSetup)
        {
            sceneOrder = new List<Scene>() {Scene.SelfReportScene, Scene.TextScene, Scene.StressScene,Scene.SelfReportScene, Scene.CalmingScene, Scene.SelfReportScene} ;
        }
        else
        {
            sceneOrder = new List<Scene>() {Scene.SelfReportScene, Scene.TextScene, Scene.StressScene,Scene.SelfReportScene, Scene.NeutralScene, Scene.SelfReportScene} ;
        }
    }

    public static void AddSelfReport(string val)
    {
        //TODO: passt szene?
        selfReports.Add(reportCounter.ToString() + val);
        reportCounter++;
    }
    
    public static void QuitAndSave()
    {
        string header = "responseNumber,frightened,worried,nervous,comfortable,pleasant,ease";
        writeCsv.MakeCSV(selfReports, header);
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }

}

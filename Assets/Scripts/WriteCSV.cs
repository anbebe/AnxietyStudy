using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; // to write to files
using System;

public class WriteCSV : MonoBehaviour
{
    string filename = ""; // filename of the csv
	

	
    public void MakeCSV(List<string> data, string header)
    {
        filename = Application.dataPath + "/Data/" + ExperimentManager.userGuid + ".csv";
        Debug.Log("save");
        TextWriter csvFile = new StreamWriter(filename, false);
        csvFile.WriteLine(header);

				
        for (int i = 0; i < data.Count; i++)
        {
            csvFile.WriteLine(data[i]);
                
        } 
			
        csvFile.Close();
        Debug.Log("finished");
    }
}
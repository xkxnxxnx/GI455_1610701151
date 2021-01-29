using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jutsmo : MonoBehaviour
{
    public string Fp1 = "Unity";
    public string Fp2 = "Unreal";
    public string Fp3 = "Pisoot";
    public string Fp4 = "Github";
    public string Fp5 = "EIEI";
    private string input;
    public Text noon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ReadStringInput(string s)
    {
        input = s;
        Debug.Log(input);
    }
    public void Button()
    {
        
        if(input == Fp1)
        {
            noon.text = "[" + "<color=green>" + Fp1 +"</color>"+"] is found.";

        }
        else 
        {
            noon.text = "[" + "<color=red>" + input + "</color>" + "] is found.";
        }
        if(input == Fp2)
        {
            noon.text = "[" + "<color=green>" + Fp2 + "</color>" + "] is found.";
        }
       
        if (input == Fp3)
        {
            noon.text = "[" + "<color=green>" + Fp3 + "</color>" + "] is found.";
        }
       
        if (input == Fp4)
        {
            noon.text = "[" + "<color=green>" + Fp4 + "</color>" + "] is found.";
        }
        
        if (input == Fp5)
        {
            noon.text = "[" + "<color=green>" + Fp5 + "</color>" + "] is found.";
        }
       

    }

}

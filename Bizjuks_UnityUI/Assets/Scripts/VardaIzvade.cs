using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VardaIzvade : MonoBehaviour
{
   
    public string teksts;
    public InputField inputField;
    public InputField inputField1;
    public Text izvade;

    public void getText()
    {
        
            Debug.Log("ok");
            string vards = inputField.text;
            int dzimsanasG = int.Parse(inputField1.text);
            int vecums = 2024 - dzimsanasG;
            teksts = $"{vards} ir {vecums} gadus vecs!";

            Debug.Log("ok");
            izvade.text = teksts;
        
        
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;



// 24.Créer des fonctions avec C# pour réutiliser son code
public class ExempleFonvtion : MonoBehaviour
{
    private string message;

    public void AfficherMessage(string message) {
        //print("MessageFonction");
        print(message);
    }

    // Start is called before the first frame update
    void Start()
    {
        print("Message Start");

        
        AfficherMessage(message);
        AfficherMessage(message);
        AfficherMessage(message);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

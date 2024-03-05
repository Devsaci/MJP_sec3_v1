using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;



// 24.Créer des fonctions avec C# pour réutiliser son code
public class ExempleFonvtion : MonoBehaviour
{
    private readonly string msg1 = "Premier Message";
    private readonly string msg2 = "Second Message";

    public void AfficherMessage(string message) {
        print("MessageFonction");
        print(message);
    }

    // Start is called before the first frame update
    void Start()
    {
        print("/////////////////////////////////");
        print("Message Start");
        print("/////////////////////////////////");
        AfficherMessage("Premier Message");
        print("/////////////////////////////////");
        AfficherMessage(msg1);
        print("/////////////////////////////////");
        AfficherMessage(msg2);
        print("/////////////////////////////////");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// 24.Cr�er des fonctions avec C# pour r�utiliser son code
public class ExempleFonvtion : MonoBehaviour
{

    public void AfficherMessage(string message) {
        //print("MessageFonction");
        print(message);
    }

    // Start is called before the first frame update
    void Start()
    {
        print("Message Start");

        
        AfficherMessage();
        AfficherMessage();
        AfficherMessage();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

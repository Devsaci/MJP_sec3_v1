using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// 24.Cr�er des fonctions avec C# pour r�utiliser son code
public class ExempleFonvtion : MonoBehaviour
{

    public void AfficherMessage() {
        print("Message");
    }

    // Start is called before the first frame update
    void Start()
    {
        AfficherMessage();
        AfficherMessage();
        AfficherMessage();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

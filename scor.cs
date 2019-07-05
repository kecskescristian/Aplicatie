using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scor : MonoBehaviour
{
    public Text text,textStop,intrebaretext;
    int nrint,intrebare=1;
    string t1 = "Activitățile cu conținut pedagogic specific,desfășurate în cadrul organizat al sistemului de învățământ, reprezintă:",
        t2 = "Influențele pedagogice exercitate spontan,de la nivelul întregii societăți,reprezintă:",
        t3 = "Concubinajul este cunoscut și sub denumirea de:",
        t4 = "Partenerii unui cuplu care nu doresc să se căsătorească,pot alege ca mod de a trăi împreună:",
        t5 = "Uniunea consensuală este specifică:",
        t6 = "Preluarea unora dintre activitățile bisericii de către alte instituții sociale constituie:",
        t7 = "Dezvoltarea sistemului de învățământ este influențată decisiv de:",
        t8 = "Activitățile cu conținut aplicativ,desfășurate într-un cadru flexibil ce sprijină activitatea școlară reprezintă:",
        t9 = "Valorile și comportamentele dobândite de un copil prin participarea la o excursie de studiu, sunt considerate ca fiind parte a educației:",
        t10 = "Sistemul de învățământ trebuie să acorde:";

    public GameObject canvas;

    void Start()
    {
        nrint = 0;
        text.text = nrint.ToString();
        intrebaretext.text = t1;
    }

    void OnTriggerEnter(Collider cub)
    {
        print(cub.tag);
        if (cub.tag == "bun") { nrint++;text.text = nrint.ToString();intrebare++;/*Debug.Log("A");*/ }
        if (cub.tag == "rau") { nrint--; text.text = nrint.ToString();intrebare++; /*Debug.Log("B");*/ }
        if (cub.tag == "stop") { canvas.SetActive(true);textStop.text = "Scorul tau este " + nrint.ToString();Debug.Log("STOP"); }
        if (intrebare == 2) intrebaretext.text = t2;
        else if (intrebare == 3) intrebaretext.text = t3;
        else if (intrebare == 4) intrebaretext.text = t4;
        else if (intrebare == 5) intrebaretext.text = t5;
        else if (intrebare == 6) intrebaretext.text = t6;
        else if (intrebare == 7) intrebaretext.text = t7;
        else if (intrebare == 8) intrebaretext.text = t8;
        else if (intrebare == 9) intrebaretext.text = t9;
        else if (intrebare == 10) intrebaretext.text = t10;
    }

}

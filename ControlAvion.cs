using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAvion : MonoBehaviour {
    float jumatateLatime;
    public Rigidbody rig;
    public int viteza;
    public Camera cam;
    public GameObject alice;
   

	
	
	void Update () {
     cam.transform.position += new Vector3(0, 0, viteza * Time.deltaTime);
       transform.position += new Vector3(0, 0, viteza * Time.deltaTime);
        alice.transform.Rotate(Vector3.forward * -1000*Time.deltaTime);

        
	}
    private void FixedUpdate()
    {
        Vector2 comanda = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector2 miscare = comanda * viteza * Time.deltaTime;

        if (miscare.x == 0 && miscare.y == 0) transform.rotation = Quaternion.Euler(0, 180, 0);
        else if (miscare.x > 0 && miscare.y == 0) transform.rotation = Quaternion.Euler(0, 180, 20);
        else if (miscare.x < 0 && miscare.y == 0) transform.rotation = Quaternion.Euler(0, 180, -20);
        else if (miscare.x == 0 && miscare.y > 0) transform.rotation = Quaternion.Euler(+10, 180, 0);
        else if (miscare.x == 0 && miscare.y < 0) transform.rotation = Quaternion.Euler(-10, 180, 0);
       // Debug.Log(miscare);

        Vector2 pozitieNoua= (Vector2)rig.position + miscare;
        if(pozitieNoua.x<=17.5f&&pozitieNoua.x>=-17.5f&&pozitieNoua.y>=-15.5f&&pozitieNoua.y<=4.7f)
        rig.position += (Vector3)miscare;
    }
}

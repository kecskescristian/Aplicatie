using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour {
    public GameObject meniu;

    public void ArataMeniu()
    {
        meniu.SetActive(true);
    }

    public void InchideMeniu()
    {
        meniu.SetActive(false);
    }

    public void Iesire()
    {
        Application.Quit();
    }

    public void Joc()
    {
        SceneManager.LoadScene(11);
    }

    public void Scena0()
    {
        SceneManager.LoadScene(4);
    }

    public void Scena1()
    {
        SceneManager.LoadScene(6);
    }

    public void Scena4()
    {
        SceneManager.LoadScene(5);
    }

    public void Scena5()
    {
        SceneManager.LoadScene(7);
    }

    public void Scena6()
    {
        SceneManager.LoadScene(8);
    }

    public void Scena9()
    {
        SceneManager.LoadScene(10);
    }

    public void Scena14()
    {
        SceneManager.LoadScene(14);
    }



    public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Prev()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}

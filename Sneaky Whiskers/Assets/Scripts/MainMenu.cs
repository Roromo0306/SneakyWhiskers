using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject panelMainMenu;
    public GameObject panelCreditos;
    public GameObject panelSelector;

    // Start is called before the first frame update
    void Start()
    {
        panelMainMenu.SetActive(true);
        panelCreditos.SetActive(false);
        panelSelector.SetActive(false);
    }

  public void AbrirCreditos()
    {
        panelMainMenu.SetActive(false);
        panelCreditos.SetActive(true);
        panelSelector.SetActive(false);
    }

   public void CerrarCreditos()
    {
        panelMainMenu.SetActive(true);
        panelCreditos.SetActive(false);
        panelSelector.SetActive(false);
    }

    public void AbrirSelector()
    {
        panelMainMenu.SetActive(false);
        panelCreditos.SetActive(false);
        panelSelector.SetActive(true);
    }

    public void CerrarSelector()
    {
        panelMainMenu.SetActive(true);
        panelCreditos.SetActive(false);
        panelSelector.SetActive(false);
    }

    public void CerrarJuego()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayoutManager : MonoBehaviour
{
    public GameObject MainLayout;
    public GameObject LeaveAR;
    public GameObject Spawner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggleAR()
    {
        Debug.Log("toggle clicked");
        MainLayout.SetActive(!MainLayout.activeSelf);
        LeaveAR.SetActive(!LeaveAR.activeSelf);
        Spawner.SetActive(!Spawner.activeSelf);
    }
}

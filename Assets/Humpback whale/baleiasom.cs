using UnityEngine;
using System.Collections;

public class baleiasom : MonoBehaviour
{

    public AudioSource sound;
    private Rect audiorect;

    void Start()
    {
        audiorect = new Rect(20, 20, 100, 20);
    }


    void Update()
    {

    }

    void OnGUI()
    {
        GUI.Label(audiorect, "Play Audio");

        if (audiorect.Contains(Event.current.mousePosition))
        {
            if (Input.GetMouseButtonDown(0))
            {
                sound.Play();
            }


        }
    }
}
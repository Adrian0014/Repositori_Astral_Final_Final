using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ObjetoInteractivo : MonoBehaviour
{
    [SerializeField] private GameObject intercativeObject;
    public Transform interctPlayer;
    private bool _alredy_Interact_Object = false;
    public AudioSource InteractObjectAudioSource;
    public AudioClip InteractObjectSound;

    void Update()
    {
        float zoneInteract = 2f;

        if(Vector3.Distance(transform.position,interctPlayer.position) < zoneInteract )
        {       
            intercativeObject.SetActive(true);        
            if(_alredy_Interact_Object == false)
            {
                InteractObjectAudioSource.PlayOneShot(InteractObjectSound);
                _alredy_Interact_Object = true;
            }
        }
        else
        {
            intercativeObject.SetActive(false);
            _alredy_Interact_Object = false;
        }

    }



}

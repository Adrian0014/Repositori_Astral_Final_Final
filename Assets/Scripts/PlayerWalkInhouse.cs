using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkInhouse : MonoBehaviour
{
    private PlayerInHouse _playerController;
    [SerializeField] private AudioSource _audioSourceSteeps;
    [SerializeField] private AudioClip _footsSteepsSound;
    private bool _alredy_Playing = false;
    void Awake()
    {
        _playerController = GetComponent<PlayerInHouse>();
    }

    void Start()
    {
        _audioSourceSteeps.loop = true;
        _audioSourceSteeps.clip = _footsSteepsSound;
    }
    void Update()
    {
        PlayFootSteepsSound();
    }

    void PlayFootSteepsSound()
    {
        if(_playerController.movement != Vector3.zero && _playerController.isGrounded == true && !_alredy_Playing)
        {
            _audioSourceSteeps.Play();
            _alredy_Playing = true;
        }
        else if(_playerController.movement == Vector3.zero || _playerController.isGrounded == false)
        {
            _audioSourceSteeps.Stop();
            _alredy_Playing = false;
        }
    }
}

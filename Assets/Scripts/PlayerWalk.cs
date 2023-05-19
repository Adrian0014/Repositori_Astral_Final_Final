
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    private Playermove _playerController;
    [SerializeField] private AudioSource _audioSourceSteeps;
    [SerializeField] private AudioClip _footsSteepsSound;
    private bool _alredy_Playing = false;
    void Awake()
    {
        _playerController = GetComponent<Playermove>();
    }

    void Start()
    {
        _audioSourceSteeps.loop = true;
        _audioSourceSteeps.clip = _footsSteepsSound;
    }

    // Update is called once per frame
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

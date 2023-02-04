using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderUi : MonoBehaviour
{
    void Update()
    {
        LookAtPlayer();
    }
    private void LookAtPlayer()     // Dolan çember sürekli kameraya bakıyor bu olmazsa dolan çemberi sağdan soldan görürüz
    {
        Camera _playerCamera = Camera.main;
        transform.LookAt(transform.position + _playerCamera.transform.rotation * Vector3.forward,
            _playerCamera.transform.rotation * Vector3.up );
    }
}

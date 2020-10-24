using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        // jarak posisi kamera thdp bola
        offset = transform.position - player.transform.position;
    }

    // LateUpdate seperti Update(), tapi dijalankan setelah semua proses update selesai (spt rigidbody, physics, dll)
    void LateUpdate()
    {
        // jadi tiap kali ada update input (spt gerak maju), posisi kamera diubah sesuai arah player, ditambah offset awal
        transform.position = player.transform.position + offset;
    }
}

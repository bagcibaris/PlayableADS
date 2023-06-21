using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderRotate : MonoBehaviour
{
    public float itmeGucu = 10f; // İtme gücü ayarı

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }   

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("HedefNesne"))
        {
            Vector3 itmeYonu = transform.position - collision.transform.position; // İtme yönü, karakterin pozisyonu ile çarpışma noktası arasındaki farktan hesaplanır
            itmeYonu = itmeYonu.normalized; // İtme yönünü normalleştir

            rb.AddForce(itmeYonu * itmeGucu, ForceMode.Impulse); // İtme gücü ile itme uygula
        }
    }
}

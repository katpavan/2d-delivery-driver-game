using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    [SerializeField] float destroyPackageTime = 0.01f;
    [SerializeField] Color32 hasPackageColor = new Color32 (129, 147, 103, 255);
    [SerializeField] Color32 noPackageColor = new Color32 ();

    SpriteRenderer sR;

    void Start() {
        sR = GetComponent<SpriteRenderer>();
        noPackageColor = sR.color;
    }
    
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package" && !hasPackage) {
            Debug.Log("package");
            hasPackage = true;
            sR.color = hasPackageColor;
            Destroy(other.gameObject, destroyPackageTime);
            
        } else if (other.tag == "Customer" && hasPackage) {
            Debug.Log("delivered");
            sR.color = noPackageColor;
            hasPackage = false;
        }
    }
}

using UnityEngine;
using System.Collections;

public class VRHapticInteraction : MonoBehaviour
{
    [Header("Pengaturan Recoil (Visual)")]
    public float pressScale = 0.8f;
    public float smoothSpeed = 10f; 

    [Header("Pengaturan Haptic (Getar)")]
    public bool useVibration = true;

    private Vector3 initialScale;
    private Vector3 targetScale;
    private bool isTouching = false;

    void Start()
    {
        initialScale = transform.localScale;
        targetScale = initialScale;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform == this.transform)
                {
                    HandleTouch(touch);
                }
            }
        }
        else
        {
            OnRelease();
        }

        transform.localScale = Vector3.Lerp(transform.localScale, targetScale, Time.deltaTime * smoothSpeed);
    }

    void HandleTouch(Touch touch)
    {
        if (touch.phase == TouchPhase.Began)
        {
            isTouching = true;
            
            if (useVibration)
            {
                Handheld.Vibrate(); 
            }

            targetScale = initialScale * pressScale;
        }
        
        else if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
        {
            OnRelease();
        }
    }

    void OnRelease()
    {
        if (isTouching)
        {
            isTouching = false;
            targetScale = initialScale;
        }
    }
}
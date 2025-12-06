using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARTrackedImageManager))]
public class ARImageHandler : MonoBehaviour
{
    private ARTrackedImageManager _trackedImageManager;

    void Awake()
    {
        _trackedImageManager = GetComponent<ARTrackedImageManager>();
    }

    void OnEnable()
    {
        _trackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;
    }

    void OnDisable()
    {
        _trackedImageManager.trackedImagesChanged -= OnTrackedImagesChanged;
    }

    void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        List<ARTrackedImage> trackedImages = new List<ARTrackedImage>();
        trackedImages.AddRange(eventArgs.added);
        trackedImages.AddRange(eventArgs.updated);

        foreach (var trackedImage in trackedImages)
        {
            if (trackedImage.trackingState == TrackingState.Tracking)
            {
                SetImageActive(trackedImage, true);
            }
            else
            {
                SetImageActive(trackedImage, false);
            }
        }

        foreach (var trackedImage in eventArgs.removed)
        {
            SetImageActive(trackedImage, false);
        }
    }

    private void SetImageActive(ARTrackedImage trackedImage, bool isActive)
    {
        if (trackedImage.transform.childCount > 0)
        {
            GameObject cylinderPrefab = trackedImage.transform.GetChild(0).gameObject;
            
            if (cylinderPrefab.activeSelf != isActive)
            {
                cylinderPrefab.SetActive(isActive);
            }
        }
    }
}
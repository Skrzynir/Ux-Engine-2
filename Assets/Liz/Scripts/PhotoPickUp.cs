using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoPickUp : MonoBehaviour
{
    public GameObject photoPrefab;
    public GameObject PhotoGroup;
    public void Collect(Sprite sprite)
    {
        GameObject newPhoto = Instantiate(photoPrefab, Vector3.zero,Quaternion.identity,PhotoGroup.transform);
    }
}

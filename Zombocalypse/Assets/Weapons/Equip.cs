using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class Equip : MonoBehaviour
{
    Vector3 itemPosition;
    Quaternion itemRotation;
    public GameObject item;
    public Transform parent;
    Transform itemTransform;
    // Start is called before the first frame update
    void Start()
    {
        itemTransform = parent;
        itemPosition = itemTransform.position;
        itemPosition.z += -0.4f;
        itemPosition.y += 0.61f;
        itemPosition.x += 0.6f;
        itemRotation = itemTransform.rotation;
        item.transform.SetParent(parent);
        Instantiate(item, itemPosition, parent.rotation, parent);
    }

    // Update is called once per frame
    void Update()
    {
        itemTransform.localEulerAngles = new Vector3(0, itemTransform.localEulerAngles.y, 0);
    }
}
